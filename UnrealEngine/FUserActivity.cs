using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001218 RID: 4632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.UserActivity")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FUserActivity : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060110D4 RID: 69844 RVA: 0x00190568 File Offset: 0x0018E768
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUserActivity._ScriptStructPtr != 0) ? FUserActivity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.UserActivity", ref FUserActivity._ScriptStructPtr);
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x060110D5 RID: 69845 RVA: 0x0019058C File Offset: 0x0018E78C
		// (set) Token: 0x060110D6 RID: 69846 RVA: 0x001905A0 File Offset: 0x0018E7A0
		public unsafe string ActionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUserActivity.__PropertyOffset_ActionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUserActivity.__PropertyOffset_ActionName)), value);
			}
		}

		// Token: 0x060110D7 RID: 69847 RVA: 0x001905B5 File Offset: 0x0018E7B5
		public FUserActivity()
		{
		}

		// Token: 0x060110D8 RID: 69848 RVA: 0x001905BD File Offset: 0x0018E7BD
		public FUserActivity(string ActionName)
		{
			this.ActionName = ActionName;
		}

		// Token: 0x060110D9 RID: 69849 RVA: 0x001905CC File Offset: 0x0018E7CC
		protected override IntPtr GetUStructPtr()
		{
			return FUserActivity.StaticStruct();
		}

		// Token: 0x060110DA RID: 69850 RVA: 0x001905D8 File Offset: 0x0018E7D8
		[NullableContext(2)]
		public FUserActivity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060110DB RID: 69851 RVA: 0x001905E2 File Offset: 0x0018E7E2
		public FUserActivity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060110DC RID: 69852 RVA: 0x001905ED File Offset: 0x0018E7ED
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUserActivity(Pointer, false, true);
		}

		// Token: 0x060110DD RID: 69853 RVA: 0x001905F7 File Offset: 0x0018E7F7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUserActivity(Pointer, MemoryOwner);
		}

		// Token: 0x0400920B RID: 37387
		public const string __ObjectPath = "/Script/Engine.UserActivity";

		// Token: 0x0400920C RID: 37388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400920D RID: 37389
		internal static int __PropertyOffset_ActionName;
	}
}
