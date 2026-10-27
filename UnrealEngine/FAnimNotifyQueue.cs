using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000829 RID: 2089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNotifyQueue")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimNotifyQueue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007074 RID: 28788 RVA: 0x000A1474 File Offset: 0x0009F674
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyQueue._ScriptStructPtr != 0) ? FAnimNotifyQueue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyQueue", ref FAnimNotifyQueue._ScriptStructPtr);
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x000A1498 File Offset: 0x0009F698
		// (set) Token: 0x06007076 RID: 28790 RVA: 0x000A14DB File Offset: 0x0009F6DB
		public TArray<FAnimNotifyEventReference> AnimNotifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEventReference> result;
				if ((result = this._AnimNotifies) == null)
				{
					result = (this._AnimNotifies = new TArray<FAnimNotifyEventReference>(base.NativePtr + (IntPtr)FAnimNotifyQueue.__PropertyOffset_AnimNotifies, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimNotifies.CopyAssign(value);
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x000A14EC File Offset: 0x0009F6EC
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x000A152F File Offset: 0x0009F72F
		public TMap<FName, FAnimNotifyArray> UnfilteredMontageAnimNotifies
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FAnimNotifyArray> result;
				if ((result = this._UnfilteredMontageAnimNotifies) == null)
				{
					result = (this._UnfilteredMontageAnimNotifies = new TMap<FName, FAnimNotifyArray>(base.NativePtr + (IntPtr)FAnimNotifyQueue.__PropertyOffset_UnfilteredMontageAnimNotifies, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnfilteredMontageAnimNotifies.CopyAssign(value);
			}
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x000A153D File Offset: 0x0009F73D
		public FAnimNotifyQueue()
		{
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x000A1545 File Offset: 0x0009F745
		public FAnimNotifyQueue(TArray<FAnimNotifyEventReference> AnimNotifies, TMap<FName, FAnimNotifyArray> UnfilteredMontageAnimNotifies)
		{
			this.AnimNotifies = AnimNotifies;
			this.UnfilteredMontageAnimNotifies = UnfilteredMontageAnimNotifies;
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x000A155B File Offset: 0x0009F75B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyQueue.StaticStruct();
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x000A1567 File Offset: 0x0009F767
		[NullableContext(2)]
		public FAnimNotifyQueue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x000A1571 File Offset: 0x0009F771
		public FAnimNotifyQueue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x000A157C File Offset: 0x0009F77C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyQueue(Pointer, false, true);
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x000A1586 File Offset: 0x0009F786
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyQueue(Pointer, MemoryOwner);
		}

		// Token: 0x040035FD RID: 13821
		public const string __ObjectPath = "/Script/Engine.AnimNotifyQueue";

		// Token: 0x040035FE RID: 13822
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035FF RID: 13823
		internal static int __PropertyOffset_AnimNotifies;

		// Token: 0x04003600 RID: 13824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEventReference> _AnimNotifies;

		// Token: 0x04003601 RID: 13825
		internal static int __PropertyOffset_UnfilteredMontageAnimNotifies;

		// Token: 0x04003602 RID: 13826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FAnimNotifyArray> _UnfilteredMontageAnimNotifies;
	}
}
