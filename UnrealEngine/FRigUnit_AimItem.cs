using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000545 RID: 1349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimItem")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FRigUnit_AimItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600470C RID: 18188 RVA: 0x0006974C File Offset: 0x0006794C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimItem._ScriptStructPtr != 0) ? FRigUnit_AimItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimItem", ref FRigUnit_AimItem._ScriptStructPtr);
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x00069770 File Offset: 0x00067970
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x000697B3 File Offset: 0x000679B3
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x000697D4 File Offset: 0x000679D4
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x00069817 File Offset: 0x00067A17
		public FRigUnit_AimItem_Target Primary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimItem_Target result;
				if ((result = this._Primary) == null)
				{
					result = (this._Primary = new FRigUnit_AimItem_Target(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Primary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimItem_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Primary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x00069838 File Offset: 0x00067A38
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x0006987B File Offset: 0x00067A7B
		public FRigUnit_AimItem_Target Secondary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimItem_Target result;
				if ((result = this._Secondary) == null)
				{
					result = (this._Secondary = new FRigUnit_AimItem_Target(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Secondary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimItem_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Secondary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x0006989C File Offset: 0x00067A9C
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x000698AC File Offset: 0x00067AAC
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x000698C0 File Offset: 0x00067AC0
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x00069903 File Offset: 0x00067B03
		public FRigUnit_AimBone_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimBone_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_AimBone_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimBone_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x00069924 File Offset: 0x00067B24
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x00069967 File Offset: 0x00067B67
		public FCachedRigElement CachedItem
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedItem) == null)
				{
					result = (this._CachedItem = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_CachedItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_CachedItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x00069988 File Offset: 0x00067B88
		// (set) Token: 0x0600471A RID: 18202 RVA: 0x000699CB File Offset: 0x00067BCB
		public FCachedRigElement PrimaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._PrimaryCachedSpace) == null)
				{
					result = (this._PrimaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_PrimaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_PrimaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x000699EC File Offset: 0x00067BEC
		// (set) Token: 0x0600471C RID: 18204 RVA: 0x00069A2F File Offset: 0x00067C2F
		public FCachedRigElement SecondaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._SecondaryCachedSpace) == null)
				{
					result = (this._SecondaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_SecondaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem.__PropertyOffset_SecondaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00069A50 File Offset: 0x00067C50
		public FRigUnit_AimItem()
		{
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00069A58 File Offset: 0x00067C58
		public FRigUnit_AimItem(FRigElementKey Item, FRigUnit_AimItem_Target Primary, FRigUnit_AimItem_Target Secondary, float Weight, FRigUnit_AimBone_DebugSettings DebugSettings, FCachedRigElement CachedItem, FCachedRigElement PrimaryCachedSpace, FCachedRigElement SecondaryCachedSpace, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Primary = Primary;
			this.Secondary = Secondary;
			this.Weight = Weight;
			this.DebugSettings = DebugSettings;
			this.CachedItem = CachedItem;
			this.PrimaryCachedSpace = PrimaryCachedSpace;
			this.SecondaryCachedSpace = SecondaryCachedSpace;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00069AB0 File Offset: 0x00067CB0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimItem.StaticStruct();
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00069ABC File Offset: 0x00067CBC
		[NullableContext(2)]
		public FRigUnit_AimItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00069AC6 File Offset: 0x00067CC6
		public FRigUnit_AimItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x00069AD1 File Offset: 0x00067CD1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimItem(Pointer, false, true);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00069ADB File Offset: 0x00067CDB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002281 RID: 8833
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AimItem";

		// Token: 0x04002282 RID: 8834
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002283 RID: 8835
		internal static int __PropertyOffset_Item;

		// Token: 0x04002284 RID: 8836
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002285 RID: 8837
		internal static int __PropertyOffset_Primary;

		// Token: 0x04002286 RID: 8838
		[Nullable(2)]
		private FRigUnit_AimItem_Target _Primary;

		// Token: 0x04002287 RID: 8839
		internal static int __PropertyOffset_Secondary;

		// Token: 0x04002288 RID: 8840
		[Nullable(2)]
		private FRigUnit_AimItem_Target _Secondary;

		// Token: 0x04002289 RID: 8841
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400228A RID: 8842
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x0400228B RID: 8843
		[Nullable(2)]
		private FRigUnit_AimBone_DebugSettings _DebugSettings;

		// Token: 0x0400228C RID: 8844
		internal static int __PropertyOffset_CachedItem;

		// Token: 0x0400228D RID: 8845
		[Nullable(2)]
		private FCachedRigElement _CachedItem;

		// Token: 0x0400228E RID: 8846
		internal static int __PropertyOffset_PrimaryCachedSpace;

		// Token: 0x0400228F RID: 8847
		[Nullable(2)]
		private FCachedRigElement _PrimaryCachedSpace;

		// Token: 0x04002290 RID: 8848
		internal static int __PropertyOffset_SecondaryCachedSpace;

		// Token: 0x04002291 RID: 8849
		[Nullable(2)]
		private FCachedRigElement _SecondaryCachedSpace;
	}
}
