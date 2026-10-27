using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002211 RID: 8721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkRefSkeleton")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLiveLinkRefSkeleton : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021387 RID: 136071 RVA: 0x0030F9EA File Offset: 0x0030DBEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkRefSkeleton._ScriptStructPtr != 0) ? FLiveLinkRefSkeleton._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkRefSkeleton", ref FLiveLinkRefSkeleton._ScriptStructPtr);
		}

		// Token: 0x170081AC RID: 33196
		// (get) Token: 0x06021388 RID: 136072 RVA: 0x0030FA10 File Offset: 0x0030DC10
		// (set) Token: 0x06021389 RID: 136073 RVA: 0x0030FA53 File Offset: 0x0030DC53
		public TArray<FName> BoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNames) == null)
				{
					result = (this._BoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FLiveLinkRefSkeleton.__PropertyOffset_BoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNames.CopyAssign(value);
			}
		}

		// Token: 0x170081AD RID: 33197
		// (get) Token: 0x0602138A RID: 136074 RVA: 0x0030FA64 File Offset: 0x0030DC64
		// (set) Token: 0x0602138B RID: 136075 RVA: 0x0030FAA7 File Offset: 0x0030DCA7
		public TArray<int> BoneParents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BoneParents) == null)
				{
					result = (this._BoneParents = new TArray<int>(base.NativePtr + (IntPtr)FLiveLinkRefSkeleton.__PropertyOffset_BoneParents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneParents.CopyAssign(value);
			}
		}

		// Token: 0x0602138C RID: 136076 RVA: 0x0030FAB5 File Offset: 0x0030DCB5
		public FLiveLinkRefSkeleton()
		{
		}

		// Token: 0x0602138D RID: 136077 RVA: 0x0030FABD File Offset: 0x0030DCBD
		public FLiveLinkRefSkeleton(TArray<FName> BoneNames, TArray<int> BoneParents)
		{
			this.BoneNames = BoneNames;
			this.BoneParents = BoneParents;
		}

		// Token: 0x0602138E RID: 136078 RVA: 0x0030FAD3 File Offset: 0x0030DCD3
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkRefSkeleton.StaticStruct();
		}

		// Token: 0x0602138F RID: 136079 RVA: 0x0030FADF File Offset: 0x0030DCDF
		[NullableContext(2)]
		public FLiveLinkRefSkeleton(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021390 RID: 136080 RVA: 0x0030FAE9 File Offset: 0x0030DCE9
		public FLiveLinkRefSkeleton(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021391 RID: 136081 RVA: 0x0030FAF4 File Offset: 0x0030DCF4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkRefSkeleton(Pointer, false, true);
		}

		// Token: 0x06021392 RID: 136082 RVA: 0x0030FAFE File Offset: 0x0030DCFE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkRefSkeleton(Pointer, MemoryOwner);
		}

		// Token: 0x04011B8B RID: 72587
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkRefSkeleton";

		// Token: 0x04011B8C RID: 72588
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B8D RID: 72589
		internal static int __PropertyOffset_BoneNames;

		// Token: 0x04011B8E RID: 72590
		[Nullable(2)]
		private TArray<FName> _BoneNames;

		// Token: 0x04011B8F RID: 72591
		internal static int __PropertyOffset_BoneParents;

		// Token: 0x04011B90 RID: 72592
		[Nullable(2)]
		private TArray<int> _BoneParents;
	}
}
