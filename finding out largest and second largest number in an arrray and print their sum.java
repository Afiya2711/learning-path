import java.util.*;
public class Main
{
	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
	int	n=sc.nextInt();
		int arr[]=new int[n];
		int temp;
		for(int i=0;i<n;i++)
		{
		    arr[i]=sc.nextInt();
		}
		for(int i=0;i<n;i++)
		{
		    for(int j=0;j<n;j++)
		    {
		        if(arr[i]<arr[j])
		        {
		           temp=arr[i];
		           arr[i]=arr[j];
		           arr[j]=temp;
		        }
		    }
		}
		int k=arr[n-1];
		int l=arr[n-2];
		System.out.println(k+l);
