��������ֻ���޸ģ�����û��ִ��add����������
�ݴ������������������Ѿ�add�����ǻ�ûִ��commit����������
����.������ʾ���е��ļ�

һ���鿴״̬��
  1��git status ����ɫ�����ڹ�������̬����ɫ�������ݴ�����
  2��git diff����add ֮ǰ������Ч������״̬Ϊ��ɫ��ʱ����Բ鿴�޸ĵ����ݣ�

��������޸ģ�
   3��git add file���ύ�����ļ���git add .���ύ�����ļ������ӹ��������ύ���ݴ�����
   4��git commit -m'��ע' �����ݴ������ύ�����ش���⣩

���������޸ģ�
   5��git checkout -- file ���ӹ�����������
   6��git reset head file�����ݴ������˵���������

�ġ��汾��־���ύ���ڡ��ύ��ע���汾�ţ���
  7��git log������ύ�汾��־��
  8��git reflog�����е��ύ��־��

�塢�汾���ˣ�
  9��git reset --hard head^���汾���˵���ǰ�汾���ϴ��ύ��״̬��
  10��git reset --hard �汾�ţ��汾���˵�ָ���汾��

����Զ�ֿ̲�

 11��������SSH Key�����û���Ŀ¼�£�������û��.sshĿ¼������У��ٿ������Ŀ¼����û��id_rsa��id_rsa.pub�������ļ�������Ѿ����ˣ���ֱ��������һ�������û�У���Shell��Windows�´�Git Bash��������SSH Key��ssh-keygen -t rsa -C "youremail@example.com"
 12����Ŀ���˺���ӱ��� public key

�ߡ����Զ�ֿ̲�
  13��git remote add origin git@github.com:Your git Account /project.git(���زֿ������Զ�ֿ̲�)
  14 ��git push -u origin master �����زֿ����͵�Զ�ֿ̲⣩

�ˡ���Զ�̿��¡
   15��git clone git@github.com:Your git Account/project.git����¡Զ�ֿ̲⵽���زֿ⣩

�� ��������ϲ���֧
   16�� �鿴��֧��git branch
   17�� ������֧��git branch <name>
    18���л���֧��git checkout <name>
    19������+�л���֧��git checkout -b <name>
    20�� �ϲ�ĳ��֧����ǰ��֧��git merge <name>
    21�� ɾ����֧��git branch -d <name>