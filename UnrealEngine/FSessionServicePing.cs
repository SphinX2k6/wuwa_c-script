using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002728 RID: 10024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SessionMessages.SessionServicePing")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSessionServicePing : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602524A RID: 152138 RVA: 0x00370369 File Offset: 0x0036E569
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSessionServicePing._ScriptStructPtr != 0) ? FSessionServicePing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SessionMessages.SessionServicePing", ref FSessionServicePing._ScriptStructPtr);
		}

		// Token: 0x17008F59 RID: 36697
		// (get) Token: 0x0602524B RID: 152139 RVA: 0x0037038D File Offset: 0x0036E58D
		// (set) Token: 0x0602524C RID: 152140 RVA: 0x003703A1 File Offset: 0x0036E5A1
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePing.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePing.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x003703B6 File Offset: 0x0036E5B6
		public FSessionServicePing()
		{
		}

		// Token: 0x0602524E RID: 152142 RVA: 0x003703BE File Offset: 0x0036E5BE
		public FSessionServicePing(string UserName)
		{
			this.UserName = UserName;
		}

		// Token: 0x0602524F RID: 152143 RVA: 0x003703CD File Offset: 0x0036E5CD
		protected override IntPtr GetUStructPtr()
		{
			return FSessionServicePing.StaticStruct();
		}

		// Token: 0x06025250 RID: 152144 RVA: 0x003703D9 File Offset: 0x0036E5D9
		[NullableContext(2)]
		public FSessionServicePing(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025251 RID: 152145 RVA: 0x003703E3 File Offset: 0x0036E5E3
		public FSessionServicePing(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025252 RID: 152146 RVA: 0x003703EE File Offset: 0x0036E5EE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSessionServicePing(Pointer, false, true);
		}

		// Token: 0x06025253 RID: 152147 RVA: 0x003703F8 File Offset: 0x0036E5F8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSessionServicePing(Pointer, MemoryOwner);
		}

		// Token: 0x0401403F RID: 81983
		public const string __ObjectPath = "/Script/SessionMessages.SessionServicePing";

		// Token: 0x04014040 RID: 81984
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014041 RID: 81985
		internal static int __PropertyOffset_UserName;
	}
}
