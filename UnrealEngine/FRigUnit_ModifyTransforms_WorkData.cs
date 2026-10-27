using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000693 RID: 1683
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyTransforms_WorkData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_ModifyTransforms_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005975 RID: 22901 RVA: 0x0008095B File Offset: 0x0007EB5B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyTransforms_WorkData._ScriptStructPtr != 0) ? FRigUnit_ModifyTransforms_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyTransforms_WorkData", ref FRigUnit_ModifyTransforms_WorkData._ScriptStructPtr);
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06005976 RID: 22902 RVA: 0x00080980 File Offset: 0x0007EB80
		// (set) Token: 0x06005977 RID: 22903 RVA: 0x000809C3 File Offset: 0x0007EBC3
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x000809D1 File Offset: 0x0007EBD1
		public FRigUnit_ModifyTransforms_WorkData()
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000809D9 File Offset: 0x0007EBD9
		public FRigUnit_ModifyTransforms_WorkData(TArray<FCachedRigElement> CachedItems)
		{
			this.CachedItems = CachedItems;
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x000809E8 File Offset: 0x0007EBE8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyTransforms_WorkData.StaticStruct();
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000809F4 File Offset: 0x0007EBF4
		[NullableContext(2)]
		public FRigUnit_ModifyTransforms_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x000809FE File Offset: 0x0007EBFE
		public FRigUnit_ModifyTransforms_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00080A09 File Offset: 0x0007EC09
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyTransforms_WorkData(Pointer, false, true);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00080A13 File Offset: 0x0007EC13
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyTransforms_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040029EF RID: 10735
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyTransforms_WorkData";

		// Token: 0x040029F0 RID: 10736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029F1 RID: 10737
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x040029F2 RID: 10738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;
	}
}
