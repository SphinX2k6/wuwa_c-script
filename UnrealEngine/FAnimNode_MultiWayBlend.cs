using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EC RID: 748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAnimNode_MultiWayBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A99 RID: 10905 RVA: 0x00040B98 File Offset: 0x0003ED98
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MultiWayBlend._ScriptStructPtr != 0) ? FAnimNode_MultiWayBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend", ref FAnimNode_MultiWayBlend._ScriptStructPtr);
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x00040BBC File Offset: 0x0003EDBC
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x00040BFF File Offset: 0x0003EDFF
		public TArray<FPoseLink> Poses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseLink> result;
				if ((result = this._Poses) == null)
				{
					result = (this._Poses = new TArray<FPoseLink>(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_Poses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Poses.CopyAssign(value);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x00040C10 File Offset: 0x0003EE10
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x00040C53 File Offset: 0x0003EE53
		public TArray<float> DesiredAlphas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DesiredAlphas) == null)
				{
					result = (this._DesiredAlphas = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_DesiredAlphas, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DesiredAlphas.CopyAssign(value);
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00040C64 File Offset: 0x0003EE64
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x00040CA7 File Offset: 0x0003EEA7
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x00040CC8 File Offset: 0x0003EEC8
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x00040CD8 File Offset: 0x0003EED8
		public unsafe bool bAdditiveNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_bAdditiveNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_bAdditiveNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x00040CE9 File Offset: 0x0003EEE9
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x00040CF9 File Offset: 0x0003EEF9
		public unsafe bool bNormalizeAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_bNormalizeAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiWayBlend.__PropertyOffset_bNormalizeAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00040D0A File Offset: 0x0003EF0A
		public FAnimNode_MultiWayBlend()
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00040D12 File Offset: 0x0003EF12
		public FAnimNode_MultiWayBlend(TArray<FPoseLink> Poses, TArray<float> DesiredAlphas, FInputScaleBias AlphaScaleBias, bool bAdditiveNode, bool bNormalizeAlpha)
		{
			this.Poses = Poses;
			this.DesiredAlphas = DesiredAlphas;
			this.AlphaScaleBias = AlphaScaleBias;
			this.bAdditiveNode = bAdditiveNode;
			this.bNormalizeAlpha = bNormalizeAlpha;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00040D3F File Offset: 0x0003EF3F
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MultiWayBlend.StaticStruct();
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00040D4B File Offset: 0x0003EF4B
		[NullableContext(2)]
		public FAnimNode_MultiWayBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00040D55 File Offset: 0x0003EF55
		public FAnimNode_MultiWayBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00040D60 File Offset: 0x0003EF60
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MultiWayBlend(Pointer, false, true);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00040D6A File Offset: 0x0003EF6A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MultiWayBlend(Pointer, MemoryOwner);
		}

		// Token: 0x04001143 RID: 4419
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_MultiWayBlend";

		// Token: 0x04001144 RID: 4420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001145 RID: 4421
		internal static int __PropertyOffset_Poses;

		// Token: 0x04001146 RID: 4422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseLink> _Poses;

		// Token: 0x04001147 RID: 4423
		internal static int __PropertyOffset_DesiredAlphas;

		// Token: 0x04001148 RID: 4424
		[Nullable(2)]
		private TArray<float> _DesiredAlphas;

		// Token: 0x04001149 RID: 4425
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x0400114A RID: 4426
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x0400114B RID: 4427
		internal static int __PropertyOffset_bAdditiveNode;

		// Token: 0x0400114C RID: 4428
		internal static int __PropertyOffset_bNormalizeAlpha;
	}
}
