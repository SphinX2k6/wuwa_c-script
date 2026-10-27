using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C8 RID: 8904
	[UnrealObjectPath("/Script/MeshDescription.ElementID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FElementID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CF7 RID: 138487 RVA: 0x0031FA46 File Offset: 0x0031DC46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FElementID._ScriptStructPtr != 0) ? FElementID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshDescription.ElementID", ref FElementID._ScriptStructPtr);
		}

		// Token: 0x17008316 RID: 33558
		// (get) Token: 0x06021CF8 RID: 138488 RVA: 0x0031FA6A File Offset: 0x0031DC6A
		// (set) Token: 0x06021CF9 RID: 138489 RVA: 0x0031FA7A File Offset: 0x0031DC7A
		public unsafe int IDValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FElementID.__PropertyOffset_IDValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FElementID.__PropertyOffset_IDValue) = value;
			}
		}

		// Token: 0x06021CFA RID: 138490 RVA: 0x0031FA8B File Offset: 0x0031DC8B
		public FElementID()
		{
		}

		// Token: 0x06021CFB RID: 138491 RVA: 0x0031FA93 File Offset: 0x0031DC93
		public FElementID(int IDValue)
		{
			this.IDValue = IDValue;
		}

		// Token: 0x06021CFC RID: 138492 RVA: 0x0031FAA2 File Offset: 0x0031DCA2
		protected override IntPtr GetUStructPtr()
		{
			return FElementID.StaticStruct();
		}

		// Token: 0x06021CFD RID: 138493 RVA: 0x0031FAAE File Offset: 0x0031DCAE
		[NullableContext(2)]
		public FElementID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CFE RID: 138494 RVA: 0x0031FAB8 File Offset: 0x0031DCB8
		public FElementID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CFF RID: 138495 RVA: 0x0031FAC3 File Offset: 0x0031DCC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FElementID(Pointer, false, true);
		}

		// Token: 0x06021D00 RID: 138496 RVA: 0x0031FACD File Offset: 0x0031DCCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FElementID(Pointer, MemoryOwner);
		}

		// Token: 0x0401209B RID: 73883
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshDescription.ElementID";

		// Token: 0x0401209C RID: 73884
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401209D RID: 73885
		internal static int __PropertyOffset_IDValue;
	}
}
