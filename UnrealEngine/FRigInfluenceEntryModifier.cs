using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000526 RID: 1318
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigInfluenceEntryModifier")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigInfluenceEntryModifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004511 RID: 17681 RVA: 0x00066DB7 File Offset: 0x00064FB7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigInfluenceEntryModifier._ScriptStructPtr != 0) ? FRigInfluenceEntryModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigInfluenceEntryModifier", ref FRigInfluenceEntryModifier._ScriptStructPtr);
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x00066DDC File Offset: 0x00064FDC
		// (set) Token: 0x06004513 RID: 17683 RVA: 0x00066E1F File Offset: 0x0006501F
		public TArray<FRigElementKey> AffectedList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigElementKey> result;
				if ((result = this._AffectedList) == null)
				{
					result = (this._AffectedList = new TArray<FRigElementKey>(base.NativePtr + (IntPtr)FRigInfluenceEntryModifier.__PropertyOffset_AffectedList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AffectedList.CopyAssign(value);
			}
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00066E2D File Offset: 0x0006502D
		public FRigInfluenceEntryModifier()
		{
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00066E35 File Offset: 0x00065035
		public FRigInfluenceEntryModifier(TArray<FRigElementKey> AffectedList)
		{
			this.AffectedList = AffectedList;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00066E44 File Offset: 0x00065044
		protected override IntPtr GetUStructPtr()
		{
			return FRigInfluenceEntryModifier.StaticStruct();
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00066E50 File Offset: 0x00065050
		[NullableContext(2)]
		public FRigInfluenceEntryModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00066E5A File Offset: 0x0006505A
		public FRigInfluenceEntryModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00066E65 File Offset: 0x00065065
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigInfluenceEntryModifier(Pointer, false, true);
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00066E6F File Offset: 0x0006506F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigInfluenceEntryModifier(Pointer, MemoryOwner);
		}

		// Token: 0x040021A6 RID: 8614
		public const string __ObjectPath = "/Script/ControlRig.RigInfluenceEntryModifier";

		// Token: 0x040021A7 RID: 8615
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021A8 RID: 8616
		internal static int __PropertyOffset_AffectedList;

		// Token: 0x040021A9 RID: 8617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigElementKey> _AffectedList;
	}
}
