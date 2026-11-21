using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000067 RID: 103
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.SoftClassPath")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoftClassPath : FSoftObjectPath, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x0001126C File Offset: 0x0000F46C
		public FSoftClassPath(UClassStackOnlyPtr Class)
		{
			base.AssetPathName = Class.GetPathName();
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00011286 File Offset: 0x0000F486
		[NullableContext(1)]
		public FSoftClassPath(UClassStackOnlyPtr Class, string SubPath)
		{
			base.AssetPathName = Class.GetPathName();
			base.SubPathString = SubPath;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000112A7 File Offset: 0x0000F4A7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoftClassPath._ScriptStructPtr != 0) ? FSoftClassPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.SoftClassPath", ref FSoftClassPath._ScriptStructPtr);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000112CB File Offset: 0x0000F4CB
		public FSoftClassPath()
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000112D3 File Offset: 0x0000F4D3
		protected override IntPtr GetUStructPtr()
		{
			return FSoftClassPath.StaticStruct();
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000112DF File Offset: 0x0000F4DF
		[NullableContext(2)]
		public FSoftClassPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000112E9 File Offset: 0x0000F4E9
		public FSoftClassPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000112F4 File Offset: 0x0000F4F4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoftClassPath(Pointer, false, true);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000112FE File Offset: 0x0000F4FE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoftClassPath(Pointer, MemoryOwner);
		}

		// Token: 0x04000185 RID: 389
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SoftClassPath";

		// Token: 0x04000186 RID: 390
		private static IntPtr _ScriptStructPtr;
	}
}
