using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan13
    {
        class Tree_node
        {
            public Tree_node(int x)
            {
                info = x;
                Left = null;
                Right = null;
            }
            public int info;
            public Tree_node Left;
            public Tree_node Right;
        }
        class Binarytree
        {
            public Binarytree()
            {
                Root = null;
            }
            public Tree_node Root;
            #region Phương thức
            //Tìm kiếm node chứa giá trị x, trả về null nếu ko tìm thấy
            public Tree_node Search(int x)
            {
                if (Root == null)
                {
                    return null;
                }
                Tree_node search = Root;
                while (search != null)
                {
                    if (search.info == x) break;
                    if (search.info < x) search = search.Right;
                    else search = search.Left;
                }
                return search;
            }
            //Thêm giá trị x vào cây
            public void InsertNode(int x)
            {
                Tree_node temp = new Tree_node(x);
                if (Root == null)
                {
                    Root = temp;
                    return;
                }
                else
                {
                    Tree_node p = Root;
                    Tree_node f = p;
                    while (p != null)
                    {
                        f = p;
                        if (p.info == x) return;
                        if (p.info < x) p = p.Right;
                        else p = p.Left;
                    }
                    if (f.info < x) f.Right = temp;
                    if (f.info > x) f.Left = temp;
                }
            }
            //Xóa nút chứa giá trị x
            public void DeleteNode(int x)
            {
                if (Root == null)
                {
                    return;
                }
                else
                {
                    Tree_node delete_node = Root;
                    Tree_node parent = null;
                    //tìm kiếm node chứa giá trị cần xóa
                    while (delete_node != null)
                    {
                        if (delete_node.info == x) break;
                        parent = delete_node;//parent lưu node cha trước khi chuyển
                        if (delete_node.info < x) delete_node = delete_node.Right;
                        else delete_node = delete_node.Left;
                    }
                    // biến delete_node là node chứa giá trị cần xóa
                    if (delete_node != null)
                    {
                        // nếu node chứa giá trị cần xóa là Lá hoặc chỉ chứa 1 con
                        if (delete_node.Left == null || delete_node.Right == null)
                        {
                            if(parent==null)
                            {
                                Root = delete_node.Left == null ? delete_node.Right : delete_node.Left;
                            }
                            else
                            if (delete_node.Left != null) if (parent.info > delete_node.info) parent.Left = delete_node.Left; else parent.Right = delete_node.Left;
                            else if (parent.info > delete_node.info) parent.Left = delete_node.Right; else parent.Right = delete_node.Right;
                        }
                        //chứa 2 con
                        else
                        {
                            Tree_node temp = delete_node.Right;
                            //Nếu nút bên phải là nút chứa giá trị gần nhất với delete_node
                            if (temp.Left == null)
                            {
                                if(parent==null)
                                {
                                    Root = temp;
                                }
                                else
                                //Gán lại liên kết giữa nút cha vs nút mới
                                if (parent.info > delete_node.info)
                                {
                                    parent.Left = temp;
                                }
                                else
                                {
                                    parent.Right = temp;
                                }
                                temp.Left = delete_node.Left;
                            }
                            else
                            {
                                //tìm giá trị nhỏ nhất ở nhánh bên phải của node cần xóa- tức giá trị gần nhất
                                while (temp.Left.Left != null)
                                {
                                    temp = temp.Left;
                                }
                                //temp chứa node gần node có giá trị nhỏ nhất ở nhanh bên phải
                                Tree_node temp0 = temp.Left;
                                temp.Left = temp0.Right;
                                //Gán lại giá trị
                                temp0.Left = delete_node.Left;
                                temp0.Right = delete_node.Right;
                                //Gán lại liên kết giữa nút cha vs nút mới
                                if (parent == null) Root = temp0;//tức nút xóa là Root của cây
                                else
                                if (parent.info > delete_node.info) parent.Left = temp0;
                                else parent.Right = temp0;
                            }
                        }
                    }
                }
            }
            //Xóa cây
            public void Clear()
            {
                Root = null;
            }
            //duyệt cây
            public void Traveres()
            {
                if (Root == null)
                {
                    Console.WriteLine("Cây rỗng");
                }
                else
                {
                    Tree_node node_temp = null;
                    Stack<Tree_node> stack_temp = new Stack<Tree_node>();
                    stack_temp.Push(Root);
                    while (stack_temp.Count > 0)
                    {
                        //Gán lại vị trí root duyệt
                        node_temp = stack_temp.Pop();
                        //duyệt từ root tới cận trái của cây
                        while (node_temp != null)
                        {
                            stack_temp.Push(node_temp);
                            node_temp = node_temp.Left;
                        }
                        //stack chứa từ root tới node cận trái
                        //đầu stack sẽ chứa giá trị cận trái=> giá trị nhỏ nhất trong cây
                        node_temp = stack_temp.Pop();
                        Console.WriteLine("{0}", node_temp.info);
                        //Kiểm tra node vừa in có node bên phải không, tức các giá trị lớn hơn node vừa in nhưng nhỏ hơn node cha
                        //không có thì chuyển sang node cha in ra đến khi gặp node có chưa node phải
                        while (node_temp.Right == null)
                        {
                            if (stack_temp.Count > 0)
                            {
                                node_temp = stack_temp.Pop();
                                Console.WriteLine("{0}", node_temp.info);
                            }
                        }
                        if (node_temp.Right != null)
                        {
                            stack_temp.Push(node_temp.Right);
                        }
                    }
                }
            }
            //Inorder duyệt theo thứ tự bên trái của node - duyệt node - duyệt bên phải của node
            public void Travere_Inorder()
            {
                Stack<Tree_node> stack_temp = new Stack<Tree_node>();
                Tree_node node_temp = Root;
                while (true)
                {
                    //nếu node_temp - vị trí con trỏ đang trỏ hiện giờ
                    if (node_temp != null)
                    {
                        //nếu khác null(tức có trỏ tới 1 node) thì cho vào trong stack , chuyển sang node bên trái
                        stack_temp.Push(node_temp);
                        node_temp = node_temp.Left;
                    }
                    else
                    {
                        //nếu null  tức đã duyệt hết bên trái
                        node_temp = stack_temp.Pop();
                        //Lấy ra và in ra giá trị đó
                        Console.Write("{0}; ", node_temp.info);
                        //chuyển sang bên phải
                        node_temp = node_temp.Right;
                    }
                }
            }
            //Postorder duyệt theo thứ tự  bên trái của node - duyệt bên phải của node - duyệt node 
            public void Travere_Postorder_2stack()
            {
                Stack<Tree_node> stack_temp1 = new Stack<Tree_node>();
                Stack<Tree_node> stack_temp2 = new Stack<Tree_node>();
                Tree_node node_temp = Root;
                stack_temp1.Push(Root);
                while (stack_temp1.Count > 0)
                {
                    node_temp = stack_temp1.Pop();
                    stack_temp2.Push(node_temp);
                    if (node_temp.Left != null) stack_temp1.Push(node_temp.Left);
                    if (node_temp.Right != null) stack_temp1.Push(node_temp.Right);
                }
                while (stack_temp2.Count > 0)
                {
                    node_temp = stack_temp2.Pop();
                    Console.Write("{0}; ", node_temp.info);
                }
            }
            public void Travere_Postorder()
            {
                Stack<Tree_node> stack_temp = new Stack<Tree_node>();
                Tree_node node_current = Root;
                while (true)
                {
                    if (node_current != null)//duyệt bên trái
                    {
                        stack_temp.Push(node_current);
                        node_current = node_current.Left;
                    }
                    else
                    {
                        if (stack_temp.Count == 0) break;
                        Tree_node temp = stack_temp.Peek().Right;
                        if (temp == null)//không có bên phải
                        {
                            //in ra node đang ở
                            temp = stack_temp.Pop();
                            Console.Write("{0}; ", temp.info);
                            while (stack_temp.Count != 0 && temp == stack_temp.Peek().Right)//in ra node duyệt cả 2 bên
                            {
                                temp = stack_temp.Pop();
                                Console.Write("{0}; ", temp.info); ;
                            }
                        }
                        else//duyệt bên phải
                        {
                            node_current = temp;
                        }

                    }
                }

            }
            //Pretorder duyệt theo thứ tự duyệt node - cây bên trái của node - duyệt cây bên phải của node  
            public void Travere_Pretorder()
            {
                Stack<Tree_node> stack_temp = new Stack<Tree_node>();
                Tree_node node_current = Root;
                stack_temp.Push(Root);
                while (true)
                {
                    node_current = stack_temp.Pop();
                    Console.Write("{0}; ", node_current.info);
                    if (node_current.Right != null) stack_temp.Push(node_current.Right);
                    if (node_current.Left != null) stack_temp.Push(node_current.Left);
                    if (stack_temp.Count == 0) break;
                }
            }
            #endregion
            //Đưa ra danh sách theo chiều giảm dần
            public static void RTLtraverse(Tree_node node)
            {
                if (node == null)     //Cay rong
                    return;
                else
                {
                    RTLtraverse(node.Right);    //Duyet cay con phai theo thu tu giua
                    Console.Write("{0} ;", node.info);                //Tham nut
                    RTLtraverse(node.Left);     //Duyet cay con trai theo thu tu giua
                }
            }
            //Đưa ra danh sách theo chiều tăng dần
            public static void LTRtraverse(Tree_node node)//Hay Inorder traver
            {
                if (node == null)     //Cay rong
                    return;
                else
                {
                    LTRtraverse(node.Left);     //Duyet cay con trai theo thu tu giua
                    Console.Write("{0}; ", node.info);                //Tham nut
                    LTRtraverse(node.Right);    //Duyet cay con phai theo thu tu giua
                }
            }
            public static void Postorder_traverse(Tree_node node)
            {
                if (node == null)     //Cay rong
                    return;
                else
                {
                    Postorder_traverse(node.Left);
                    Postorder_traverse(node.Right);
                    Console.Write("{0}; ", node.info);
                }
            }
            public static void Pretorder_traverse(Tree_node node)
            {
                if (node == null)     //Cay rong
                    return;
                else
                {
                    Console.Write("{0}; ", node.info);                //Tham nut
                    Pretorder_traverse(node.Left);     //Duyet cay con trai 
                    Pretorder_traverse(node.Right);    //Duyet cay con phai 
                }
            }
        }
        public static void Tuan13_main()
        {
            Binarytree tree = new Binarytree();
            tree.InsertNode(50);
            tree.InsertNode(30);
            tree.InsertNode(20);
            tree.InsertNode(40);
            tree.InsertNode(35);
            tree.InsertNode(37);
            tree.InsertNode(36);
            tree.InsertNode(38);
            tree.InsertNode(45);
            tree.InsertNode(90);
            tree.InsertNode(100);
            tree.InsertNode(95);
            tree.InsertNode(85);
            tree.InsertNode(80);
            tree.DeleteNode(50);
            Console.WriteLine("\nPostorder");
            Binarytree.Postorder_traverse(tree.Root);
            Console.WriteLine("\nPretorder");
            Binarytree.Pretorder_traverse(tree.Root);
            Console.WriteLine("\nLTRtraverser");
            Binarytree.LTRtraverse(tree.Root);
            Console.ReadKey();
        }
    }
}
