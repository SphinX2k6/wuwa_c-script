using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015D4 RID: 5588
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiMultiFix")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKawaiiMultiFix : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014254 RID: 82516 RVA: 0x001D969F File Offset: 0x001D789F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiMultiFix._ScriptStructPtr != 0) ? FKawaiiMultiFix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiMultiFix", ref FKawaiiMultiFix._ScriptStructPtr);
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06014255 RID: 82517 RVA: 0x001D96C4 File Offset: 0x001D78C4
		// (set) Token: 0x06014256 RID: 82518 RVA: 0x001D9707 File Offset: 0x001D7907
		public FBoneReference Root
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Root) == null)
				{
					result = (this._Root = new FBoneReference(base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_Root, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_Root, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x06014257 RID: 82519 RVA: 0x001D9728 File Offset: 0x001D7928
		// (set) Token: 0x06014258 RID: 82520 RVA: 0x001D9738 File Offset: 0x001D7938
		public unsafe float RootWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_RootWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_RootWeight) = value;
			}
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x06014259 RID: 82521 RVA: 0x001D974C File Offset: 0x001D794C
		// (set) Token: 0x0601425A RID: 82522 RVA: 0x001D978F File Offset: 0x001D798F
		public TArray<FBoneReference> OtherFixBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._OtherFixBones) == null)
				{
					result = (this._OtherFixBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_OtherFixBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherFixBones.CopyAssign(value);
			}
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x0601425B RID: 82523 RVA: 0x001D97A0 File Offset: 0x001D79A0
		// (set) Token: 0x0601425C RID: 82524 RVA: 0x001D97E3 File Offset: 0x001D79E3
		public TArray<float> OtherWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._OtherWeights) == null)
				{
					result = (this._OtherWeights = new TArray<float>(base.NativePtr + (IntPtr)FKawaiiMultiFix.__PropertyOffset_OtherWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherWeights.CopyAssign(value);
			}
		}

		// Token: 0x0601425D RID: 82525 RVA: 0x001D97F1 File Offset: 0x001D79F1
		public FKawaiiMultiFix()
		{
		}

		// Token: 0x0601425E RID: 82526 RVA: 0x001D97F9 File Offset: 0x001D79F9
		public FKawaiiMultiFix(FBoneReference Root, float RootWeight, TArray<FBoneReference> OtherFixBones, TArray<float> OtherWeights)
		{
			this.Root = Root;
			this.RootWeight = RootWeight;
			this.OtherFixBones = OtherFixBones;
			this.OtherWeights = OtherWeights;
		}

		// Token: 0x0601425F RID: 82527 RVA: 0x001D981E File Offset: 0x001D7A1E
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiMultiFix.StaticStruct();
		}

		// Token: 0x06014260 RID: 82528 RVA: 0x001D982A File Offset: 0x001D7A2A
		[NullableContext(2)]
		public FKawaiiMultiFix(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014261 RID: 82529 RVA: 0x001D9834 File Offset: 0x001D7A34
		public FKawaiiMultiFix(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014262 RID: 82530 RVA: 0x001D983F File Offset: 0x001D7A3F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiMultiFix(Pointer, false, true);
		}

		// Token: 0x06014263 RID: 82531 RVA: 0x001D9849 File Offset: 0x001D7A49
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiMultiFix(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF4F RID: 44879
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiMultiFix";

		// Token: 0x0400AF50 RID: 44880
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF51 RID: 44881
		internal static int __PropertyOffset_Root;

		// Token: 0x0400AF52 RID: 44882
		[Nullable(2)]
		private FBoneReference _Root;

		// Token: 0x0400AF53 RID: 44883
		internal static int __PropertyOffset_RootWeight;

		// Token: 0x0400AF54 RID: 44884
		internal static int __PropertyOffset_OtherFixBones;

		// Token: 0x0400AF55 RID: 44885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _OtherFixBones;

		// Token: 0x0400AF56 RID: 44886
		internal static int __PropertyOffset_OtherWeights;

		// Token: 0x0400AF57 RID: 44887
		[Nullable(2)]
		private TArray<float> _OtherWeights;
	}
}
