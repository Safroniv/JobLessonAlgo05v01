//Реализовать DFS и BFS для дерева с выводом каждого шага в консоль

using JobLessonAlgo05v01Part01;


BfsDfsSearch bdsDfsSort = new BfsDfsSearch();
bdsDfsSort.RandomTree(100);
int search = new Random().Next(10000);

TreeNode bFSearch = bdsDfsSort.BFSearch(search);
string textBFS = bFSearch != null ? bFSearch.Value.ToString() : "пустой";

TreeNode dFSearch = bdsDfsSort.DFSearch(search);
string textDFS = dFSearch != null ? dFSearch.Value.ToString() : "пустой";
