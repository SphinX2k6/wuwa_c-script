using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001103 RID: 4355
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSkeletalMeshSamplingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCCA RID: 64714 RVA: 0x0017558F File Offset: 0x0017378F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingInfo._ScriptStructPtr != 0) ? FSkeletalMeshSamplingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingInfo", ref FSkeletalMeshSamplingInfo._ScriptStructPtr);
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600FCCB RID: 64715 RVA: 0x001755B4 File Offset: 0x001737B4
		// (set) Token: 0x0600FCCC RID: 64716 RVA: 0x001755F7 File Offset: 0x001737F7
		public TArray<FSkeletalMeshSamplingRegion> Regions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshSamplingRegion> result;
				if ((result = this._Regions) == null)
				{
					result = (this._Regions = new TArray<FSkeletalMeshSamplingRegion>(base.NativePtr + (IntPtr)FSkeletalMeshSamplingInfo.__PropertyOffset_Regions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Regions.CopyAssign(value);
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600FCCD RID: 64717 RVA: 0x00175608 File Offset: 0x00173808
		// (set) Token: 0x0600FCCE RID: 64718 RVA: 0x0017564B File Offset: 0x0017384B
		public FSkeletalMeshSamplingBuiltData BuiltData
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletalMeshSamplingBuiltData result;
				if ((result = this._BuiltData) == null)
				{
					result = (this._BuiltData = new FSkeletalMeshSamplingBuiltData(base.NativePtr + (IntPtr)FSkeletalMeshSamplingInfo.__PropertyOffset_BuiltData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletalMeshSamplingBuiltData.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshSamplingInfo.__PropertyOffset_BuiltData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600FCCF RID: 64719 RVA: 0x0017566C File Offset: 0x0017386C
		public FSkeletalMeshSamplingInfo()
		{
		}

		// Token: 0x0600FCD0 RID: 64720 RVA: 0x00175674 File Offset: 0x00173874
		public FSkeletalMeshSamplingInfo(TArray<FSkeletalMeshSamplingRegion> Regions, FSkeletalMeshSamplingBuiltData BuiltData)
		{
			this.Regions = Regions;
			this.BuiltData = BuiltData;
		}

		// Token: 0x0600FCD1 RID: 64721 RVA: 0x0017568A File Offset: 0x0017388A
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingInfo.StaticStruct();
		}

		// Token: 0x0600FCD2 RID: 64722 RVA: 0x00175696 File Offset: 0x00173896
		[NullableContext(2)]
		public FSkeletalMeshSamplingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCD3 RID: 64723 RVA: 0x001756A0 File Offset: 0x001738A0
		public FSkeletalMeshSamplingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCD4 RID: 64724 RVA: 0x001756AB File Offset: 0x001738AB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingInfo(Pointer, false, true);
		}

		// Token: 0x0600FCD5 RID: 64725 RVA: 0x001756B5 File Offset: 0x001738B5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008846 RID: 34886
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingInfo";

		// Token: 0x04008847 RID: 34887
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008848 RID: 34888
		internal static int __PropertyOffset_Regions;

		// Token: 0x04008849 RID: 34889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshSamplingRegion> _Regions;

		// Token: 0x0400884A RID: 34890
		internal static int __PropertyOffset_BuiltData;

		// Token: 0x0400884B RID: 34891
		[Nullable(2)]
		private FSkeletalMeshSamplingBuiltData _BuiltData;
	}
}
