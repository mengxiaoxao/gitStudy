工作区：只是修改，但是没有执行add操作的区域
暂存区：工作区的内容已经add。但是还没执行commit操作的区域
“”.“”表示所有的文件

一、查看状态：
  1、git status （红色代表在工作区域态，绿色代表在暂存区）
  2、git diff（在add 之前操作有效，即是状态为红色的时候可以查看修改的内容）

二、添加修改：
   3、git add file（提交单个文件）git add .（提交所有文件）（从工作区域提交到暂存区域）
   4、git commit -m'备注' （从暂存区域提交到本地代码库）

三、撤销修改：
   5、git checkout -- file （从工作区撤销）
   6、git reset head file（从暂存区回退到工作区）

四、版本日志（提交日期、提交备注、版本号）：
  7、git log（最近提交版本日志）
  8、git reflog（所有的提交日志）

五、版本回退：
  9、git reset --hard head^（版本回退到当前版本的上次提交的状态）
  10、git reset --hard 版本号（版本回退到指定版本）

六、远程仓库

 11步：创建SSH Key。在用户主目录下，看看有没有.ssh目录，如果有，再看看这个目录下有没有id_rsa和id_rsa.pub这两个文件，如果已经有了，可直接跳到下一步。如果没有，打开Shell（Windows下打开Git Bash），创建SSH Key：ssh-keygen -t rsa -C "youremail@example.com"
 12、在目标账号添加本地 public key

七、添加远程仓库
  13、git remote add origin git@github.com:Your git Account /project.git(本地仓库关联到远程仓库)
  14 、git push -u origin master （本地仓库推送到远程仓库）

八、从远程库克隆
   15、git clone git@github.com:Your git Account/project.git（克隆远程仓库到本地仓库）

九 、创建与合并分支
   16、 查看分支：git branch
   17、 创建分支：git branch <name>
    18、切换分支：git checkout <name>
    19、创建+切换分支：git checkout -b <name>
    20、 合并某分支到当前分支：git merge <name>
    21、 删除分支：git branch -d <name>