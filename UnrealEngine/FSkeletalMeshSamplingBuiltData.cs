using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001102 RID: 4354
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingBuiltData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSkeletalMeshSamplingBuiltData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCBE RID: 64702 RVA: 0x00175474 File Offset: 0x00173674
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingBuiltData._ScriptStructPtr != 0) ? FSkeletalMeshSamplingBuiltData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingBuiltData", ref FSkeletalMeshSamplingBuiltData._ScriptStructPtr);
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600FCBF RID: 64703 RVA: 0x00175498 File Offset: 0x00173698
		// (set) Token: 0x0600FCC0 RID: 64704 RVA: 0x001754DB File Offset: 0x001736DB
		public TArray<FSkeletalMeshSamplingLODBuiltData> WholeMeshBuiltData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshSamplingLODBuiltData> result;
				if ((result = this._WholeMeshBuiltData) == null)
				{
					result = (this._WholeMeshBuiltData = new TArray<FSkeletalMeshSamplingLODBuiltData>(base.NativePtr + (IntPtr)FSkeletalMeshSamplingBuiltData.__PropertyOffset_WholeMeshBuiltData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WholeMeshBuiltData.CopyAssign(value);
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600FCC1 RID: 64705 RVA: 0x001754EC File Offset: 0x001736EC
		// (set) Token: 0x0600FCC2 RID: 64706 RVA: 0x0017552F File Offset: 0x0017372F
		public TArray<FSkeletalMeshSamplingRegionBuiltData> RegionBuiltData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshSamplingRegionBuiltData> result;
				if ((result = this._RegionBuiltData) == null)
				{
					result = (this._RegionBuiltData = new TArray<FSkeletalMeshSamplingRegionBuiltData>(base.NativePtr + (IntPtr)FSkeletalMeshSamplingBuiltData.__PropertyOffset_RegionBuiltData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RegionBuiltData.CopyAssign(value);
			}
		}

		// Token: 0x0600FCC3 RID: 64707 RVA: 0x0017553D File Offset: 0x0017373D
		public FSkeletalMeshSamplingBuiltData()
		{
		}

		// Token: 0x0600FCC4 RID: 64708 RVA: 0x00175545 File Offset: 0x00173745
		public FSkeletalMeshSamplingBuiltData(TArray<FSkeletalMeshSamplingLODBuiltData> WholeMeshBuiltData, TArray<FSkeletalMeshSamplingRegionBuiltData> RegionBuiltData)
		{
			this.WholeMeshBuiltData = WholeMeshBuiltData;
			this.RegionBuiltData = RegionBuiltData;
		}

		// Token: 0x0600FCC5 RID: 64709 RVA: 0x0017555B File Offset: 0x0017375B
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingBuiltData.StaticStruct();
		}

		// Token: 0x0600FCC6 RID: 64710 RVA: 0x00175567 File Offset: 0x00173767
		[NullableContext(2)]
		public FSkeletalMeshSamplingBuiltData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCC7 RID: 64711 RVA: 0x00175571 File Offset: 0x00173771
		public FSkeletalMeshSamplingBuiltData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCC8 RID: 64712 RVA: 0x0017557C File Offset: 0x0017377C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingBuiltData(Pointer, false, true);
		}

		// Token: 0x0600FCC9 RID: 64713 RVA: 0x00175586 File Offset: 0x00173786
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingBuiltData(Pointer, MemoryOwner);
		}

		// Token: 0x04008840 RID: 34880
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingBuiltData";

		// Token: 0x04008841 RID: 34881
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008842 RID: 34882
		internal static int __PropertyOffset_WholeMeshBuiltData;

		// Token: 0x04008843 RID: 34883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshSamplingLODBuiltData> _WholeMeshBuiltData;

		// Token: 0x04008844 RID: 34884
		internal static int __PropertyOffset_RegionBuiltData;

		// Token: 0x04008845 RID: 34885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshSamplingRegionBuiltData> _RegionBuiltData;
	}
}
