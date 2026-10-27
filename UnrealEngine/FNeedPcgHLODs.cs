using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EE5 RID: 3813
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NeedPcgHLODs")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FNeedPcgHLODs : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CE8D RID: 52877 RVA: 0x0012D6DD File Offset: 0x0012B8DD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNeedPcgHLODs._ScriptStructPtr != 0) ? FNeedPcgHLODs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NeedPcgHLODs", ref FNeedPcgHLODs._ScriptStructPtr);
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600CE8E RID: 52878 RVA: 0x0012D704 File Offset: 0x0012B904
		// (set) Token: 0x0600CE8F RID: 52879 RVA: 0x0012D747 File Offset: 0x0012B947
		public TSet<FGuid> HLODGuids
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FGuid> result;
				if ((result = this._HLODGuids) == null)
				{
					result = (this._HLODGuids = new TSet<FGuid>(base.NativePtr + (IntPtr)FNeedPcgHLODs.__PropertyOffset_HLODGuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HLODGuids.CopyAssign(value);
			}
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x0012D755 File Offset: 0x0012B955
		public FNeedPcgHLODs()
		{
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x0012D75D File Offset: 0x0012B95D
		public FNeedPcgHLODs(TSet<FGuid> HLODGuids)
		{
			this.HLODGuids = HLODGuids;
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x0012D76C File Offset: 0x0012B96C
		protected override IntPtr GetUStructPtr()
		{
			return FNeedPcgHLODs.StaticStruct();
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x0012D778 File Offset: 0x0012B978
		[NullableContext(2)]
		public FNeedPcgHLODs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x0012D782 File Offset: 0x0012B982
		public FNeedPcgHLODs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x0012D78D File Offset: 0x0012B98D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNeedPcgHLODs(Pointer, false, true);
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x0012D797 File Offset: 0x0012B997
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNeedPcgHLODs(Pointer, MemoryOwner);
		}

		// Token: 0x04006F64 RID: 28516
		public const string __ObjectPath = "/Script/Engine.NeedPcgHLODs";

		// Token: 0x04006F65 RID: 28517
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006F66 RID: 28518
		internal static int __PropertyOffset_HLODGuids;

		// Token: 0x04006F67 RID: 28519
		[Nullable(2)]
		private TSet<FGuid> _HLODGuids;
	}
}
