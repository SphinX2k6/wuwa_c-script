using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000082 RID: 130
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.SoftClassPath")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoftClassPath : FSoftObjectPath, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x000164F0 File Offset: 0x000146F0
		public FSoftClassPath(UClassStackOnlyPtr Class) : base(Class.GetPathName(), string.Empty)
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00016509 File Offset: 0x00014709
		public FSoftClassPath(UClassStackOnlyPtr Class, string SubPath) : base(Class.GetPathName(), SubPath)
		{
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0001651E File Offset: 0x0001471E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoftClassPath._ScriptStructPtr != 0) ? FSoftClassPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.SoftClassPath", ref FSoftClassPath._ScriptStructPtr);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00016542 File Offset: 0x00014742
		public FSoftClassPath()
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0001654A File Offset: 0x0001474A
		public FSoftClassPath(FName AssetPathName, string SubPathString)
		{
			base.AssetPathName = AssetPathName;
			base.SubPathString = SubPathString;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00016560 File Offset: 0x00014760
		protected override IntPtr GetUStructPtr()
		{
			return FSoftClassPath.StaticStruct();
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0001656C File Offset: 0x0001476C
		[NullableContext(2)]
		public FSoftClassPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00016576 File Offset: 0x00014776
		public FSoftClassPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00016581 File Offset: 0x00014781
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoftClassPath(Pointer, false, true);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0001658B File Offset: 0x0001478B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoftClassPath(Pointer, MemoryOwner);
		}

		// Token: 0x040001CC RID: 460
		public new const string __ObjectPath = "/Script/CoreUObject.SoftClassPath";

		// Token: 0x040001CD RID: 461
		private static IntPtr _ScriptStructPtr;
	}
}
