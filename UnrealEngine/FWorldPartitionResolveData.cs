using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200126B RID: 4715
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionResolveData")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWorldPartitionResolveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060114B8 RID: 70840 RVA: 0x00196486 File Offset: 0x00194686
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionResolveData._ScriptStructPtr != 0) ? FWorldPartitionResolveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionResolveData", ref FWorldPartitionResolveData._ScriptStructPtr);
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x060114B9 RID: 70841 RVA: 0x001964AC File Offset: 0x001946AC
		// (set) Token: 0x060114BA RID: 70842 RVA: 0x001964EF File Offset: 0x001946EF
		public FActorContainerID ContainerID
		{
			get
			{
				base.FastCheckIsValid();
				FActorContainerID result;
				if ((result = this._ContainerID) == null)
				{
					result = (this._ContainerID = new FActorContainerID(base.NativePtr + (IntPtr)FWorldPartitionResolveData.__PropertyOffset_ContainerID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorContainerID.StaticStruct(), base.NativePtr + (IntPtr)FWorldPartitionResolveData.__PropertyOffset_ContainerID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x060114BB RID: 70843 RVA: 0x00196510 File Offset: 0x00194710
		// (set) Token: 0x060114BC RID: 70844 RVA: 0x00196553 File Offset: 0x00194753
		public FTopLevelAssetPath SourceWorldAssetPath
		{
			get
			{
				base.FastCheckIsValid();
				FTopLevelAssetPath result;
				if ((result = this._SourceWorldAssetPath) == null)
				{
					result = (this._SourceWorldAssetPath = new FTopLevelAssetPath(base.NativePtr + (IntPtr)FWorldPartitionResolveData.__PropertyOffset_SourceWorldAssetPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTopLevelAssetPath.StaticStruct(), base.NativePtr + (IntPtr)FWorldPartitionResolveData.__PropertyOffset_SourceWorldAssetPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060114BD RID: 70845 RVA: 0x00196574 File Offset: 0x00194774
		public FWorldPartitionResolveData()
		{
		}

		// Token: 0x060114BE RID: 70846 RVA: 0x0019657C File Offset: 0x0019477C
		public FWorldPartitionResolveData(FActorContainerID ContainerID, FTopLevelAssetPath SourceWorldAssetPath)
		{
			this.ContainerID = ContainerID;
			this.SourceWorldAssetPath = SourceWorldAssetPath;
		}

		// Token: 0x060114BF RID: 70847 RVA: 0x00196592 File Offset: 0x00194792
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionResolveData.StaticStruct();
		}

		// Token: 0x060114C0 RID: 70848 RVA: 0x0019659E File Offset: 0x0019479E
		[NullableContext(2)]
		public FWorldPartitionResolveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060114C1 RID: 70849 RVA: 0x001965A8 File Offset: 0x001947A8
		public FWorldPartitionResolveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060114C2 RID: 70850 RVA: 0x001965B3 File Offset: 0x001947B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionResolveData(Pointer, false, true);
		}

		// Token: 0x060114C3 RID: 70851 RVA: 0x001965BD File Offset: 0x001947BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionResolveData(Pointer, MemoryOwner);
		}

		// Token: 0x0400941A RID: 37914
		public const string __ObjectPath = "/Script/Engine.WorldPartitionResolveData";

		// Token: 0x0400941B RID: 37915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400941C RID: 37916
		internal static int __PropertyOffset_ContainerID;

		// Token: 0x0400941D RID: 37917
		[Nullable(2)]
		private FActorContainerID _ContainerID;

		// Token: 0x0400941E RID: 37918
		internal static int __PropertyOffset_SourceWorldAssetPath;

		// Token: 0x0400941F RID: 37919
		[Nullable(2)]
		private FTopLevelAssetPath _SourceWorldAssetPath;
	}
}
