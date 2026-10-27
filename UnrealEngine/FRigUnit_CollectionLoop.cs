using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056E RID: 1390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionLoop")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FRigUnit_CollectionLoop : FRigUnit_CollectionBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049F4 RID: 18932 RVA: 0x0006DC8A File Offset: 0x0006BE8A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionLoop._ScriptStructPtr != 0) ? FRigUnit_CollectionLoop._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionLoop", ref FRigUnit_CollectionLoop._ScriptStructPtr);
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0006DCB0 File Offset: 0x0006BEB0
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0006DCF3 File Offset: 0x0006BEF3
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x0006DD14 File Offset: 0x0006BF14
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x0006DD57 File Offset: 0x0006BF57
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x0006DD78 File Offset: 0x0006BF78
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x0006DD88 File Offset: 0x0006BF88
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x0006DD99 File Offset: 0x0006BF99
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x0006DDA9 File Offset: 0x0006BFA9
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x0006DDBA File Offset: 0x0006BFBA
		// (set) Token: 0x060049FE RID: 18942 RVA: 0x0006DDCA File Offset: 0x0006BFCA
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x0006DDDB File Offset: 0x0006BFDB
		// (set) Token: 0x06004A00 RID: 18944 RVA: 0x0006DDEB File Offset: 0x0006BFEB
		public unsafe bool Continue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Continue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Continue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x0006DDFC File Offset: 0x0006BFFC
		// (set) Token: 0x06004A02 RID: 18946 RVA: 0x0006DE3F File Offset: 0x0006C03F
		public FControlRigExecuteContext Completed
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Completed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionLoop.__PropertyOffset_Completed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x0006DE60 File Offset: 0x0006C060
		public FRigUnit_CollectionLoop()
		{
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x0006DE68 File Offset: 0x0006C068
		public FRigUnit_CollectionLoop(FRigElementKeyCollection Collection, FRigElementKey Item, int Index, int Count, float Ratio, bool Continue, FControlRigExecuteContext Completed, FControlRigExecuteContext ExecuteContext)
		{
			this.Collection = Collection;
			this.Item = Item;
			this.Index = Index;
			this.Count = Count;
			this.Ratio = Ratio;
			this.Continue = Continue;
			this.Completed = Completed;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x0006DEB8 File Offset: 0x0006C0B8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionLoop.StaticStruct();
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x0006DEC4 File Offset: 0x0006C0C4
		[NullableContext(2)]
		public FRigUnit_CollectionLoop(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x0006DECE File Offset: 0x0006C0CE
		public FRigUnit_CollectionLoop(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x0006DED9 File Offset: 0x0006C0D9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionLoop(Pointer, false, true);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x0006DEE3 File Offset: 0x0006C0E3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionLoop(Pointer, MemoryOwner);
		}

		// Token: 0x040023EA RID: 9194
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionLoop";

		// Token: 0x040023EB RID: 9195
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023EC RID: 9196
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023ED RID: 9197
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023EE RID: 9198
		internal static int __PropertyOffset_Item;

		// Token: 0x040023EF RID: 9199
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x040023F0 RID: 9200
		internal static int __PropertyOffset_Index;

		// Token: 0x040023F1 RID: 9201
		internal static int __PropertyOffset_Count;

		// Token: 0x040023F2 RID: 9202
		internal static int __PropertyOffset_Ratio;

		// Token: 0x040023F3 RID: 9203
		internal static int __PropertyOffset_Continue;

		// Token: 0x040023F4 RID: 9204
		internal static int __PropertyOffset_Completed;

		// Token: 0x040023F5 RID: 9205
		[Nullable(2)]
		private FControlRigExecuteContext _Completed;
	}
}
