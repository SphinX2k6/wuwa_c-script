using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200160C RID: 5644
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_FollowAnims")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FAnimNode_FollowAnims : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060145D4 RID: 83412 RVA: 0x001DED7C File Offset: 0x001DCF7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_FollowAnims._ScriptStructPtr != 0) ? FAnimNode_FollowAnims._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_FollowAnims", ref FAnimNode_FollowAnims._ScriptStructPtr);
		}

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x060145D5 RID: 83413 RVA: 0x001DEDA0 File Offset: 0x001DCFA0
		// (set) Token: 0x060145D6 RID: 83414 RVA: 0x001DEDE3 File Offset: 0x001DCFE3
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_FollowAnims.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_FollowAnims.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x060145D7 RID: 83415 RVA: 0x001DEE04 File Offset: 0x001DD004
		// (set) Token: 0x060145D8 RID: 83416 RVA: 0x001DEE47 File Offset: 0x001DD047
		public TMap<string, UAnimSequenceBase> AnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UAnimSequenceBase> result;
				if ((result = this._AnimMap) == null)
				{
					result = (this._AnimMap = new TMap<string, UAnimSequenceBase>(base.NativePtr + (IntPtr)FAnimNode_FollowAnims.__PropertyOffset_AnimMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimMap.CopyAssign(value);
			}
		}

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x060145D9 RID: 83417 RVA: 0x001DEE58 File Offset: 0x001DD058
		// (set) Token: 0x060145DA RID: 83418 RVA: 0x001DEE9B File Offset: 0x001DD09B
		public TSet<FName> Slots
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._Slots) == null)
				{
					result = (this._Slots = new TSet<FName>(base.NativePtr + (IntPtr)FAnimNode_FollowAnims.__PropertyOffset_Slots, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Slots.CopyAssign(value);
			}
		}

		// Token: 0x060145DB RID: 83419 RVA: 0x001DEEA9 File Offset: 0x001DD0A9
		public FAnimNode_FollowAnims()
		{
		}

		// Token: 0x060145DC RID: 83420 RVA: 0x001DEEB1 File Offset: 0x001DD0B1
		public FAnimNode_FollowAnims(FPoseLink Base, TMap<string, UAnimSequenceBase> AnimMap, TSet<FName> Slots)
		{
			this.Base = Base;
			this.AnimMap = AnimMap;
			this.Slots = Slots;
		}

		// Token: 0x060145DD RID: 83421 RVA: 0x001DEECE File Offset: 0x001DD0CE
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_FollowAnims.StaticStruct();
		}

		// Token: 0x060145DE RID: 83422 RVA: 0x001DEEDA File Offset: 0x001DD0DA
		[NullableContext(2)]
		public FAnimNode_FollowAnims(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060145DF RID: 83423 RVA: 0x001DEEE4 File Offset: 0x001DD0E4
		public FAnimNode_FollowAnims(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060145E0 RID: 83424 RVA: 0x001DEEEF File Offset: 0x001DD0EF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_FollowAnims(Pointer, false, true);
		}

		// Token: 0x060145E1 RID: 83425 RVA: 0x001DEEF9 File Offset: 0x001DD0F9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_FollowAnims(Pointer, MemoryOwner);
		}

		// Token: 0x0400B14E RID: 45390
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_FollowAnims";

		// Token: 0x0400B14F RID: 45391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B150 RID: 45392
		internal static int __PropertyOffset_Base;

		// Token: 0x0400B151 RID: 45393
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x0400B152 RID: 45394
		internal static int __PropertyOffset_AnimMap;

		// Token: 0x0400B153 RID: 45395
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UAnimSequenceBase> _AnimMap;

		// Token: 0x0400B154 RID: 45396
		internal static int __PropertyOffset_Slots;

		// Token: 0x0400B155 RID: 45397
		[Nullable(2)]
		private TSet<FName> _Slots;
	}
}
