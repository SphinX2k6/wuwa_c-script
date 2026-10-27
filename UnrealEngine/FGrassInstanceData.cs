using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A9D RID: 6813
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.GrassInstanceData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGrassInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601935E RID: 103262 RVA: 0x00254B70 File Offset: 0x00252D70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGrassInstanceData._ScriptStructPtr != 0) ? FGrassInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.GrassInstanceData", ref FGrassInstanceData._ScriptStructPtr);
		}

		// Token: 0x17006473 RID: 25715
		// (get) Token: 0x0601935F RID: 103263 RVA: 0x00254B94 File Offset: 0x00252D94
		// (set) Token: 0x06019360 RID: 103264 RVA: 0x00254BA8 File Offset: 0x00252DA8
		[Nullable(2)]
		public unsafe UHierarchicalInstancedStaticMeshComponent HISM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHierarchicalInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FGrassInstanceData.__PropertyOffset_HISM);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGrassInstanceData.__PropertyOffset_HISM, value);
			}
		}

		// Token: 0x17006474 RID: 25716
		// (get) Token: 0x06019361 RID: 103265 RVA: 0x00254BC0 File Offset: 0x00252DC0
		// (set) Token: 0x06019362 RID: 103266 RVA: 0x00254C03 File Offset: 0x00252E03
		public TArray<int> InstanceIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceIndices) == null)
				{
					result = (this._InstanceIndices = new TArray<int>(base.NativePtr + (IntPtr)FGrassInstanceData.__PropertyOffset_InstanceIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InstanceIndices.CopyAssign(value);
			}
		}

		// Token: 0x17006475 RID: 25717
		// (get) Token: 0x06019363 RID: 103267 RVA: 0x00254C11 File Offset: 0x00252E11
		// (set) Token: 0x06019364 RID: 103268 RVA: 0x00254C25 File Offset: 0x00252E25
		public unsafe FName ComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassInstanceData.__PropertyOffset_ComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassInstanceData.__PropertyOffset_ComponentName) = value;
			}
		}

		// Token: 0x06019365 RID: 103269 RVA: 0x00254C3A File Offset: 0x00252E3A
		public FGrassInstanceData()
		{
		}

		// Token: 0x06019366 RID: 103270 RVA: 0x00254C42 File Offset: 0x00252E42
		public FGrassInstanceData(UHierarchicalInstancedStaticMeshComponent HISM, TArray<int> InstanceIndices, FName ComponentName)
		{
			this.HISM = HISM;
			this.InstanceIndices = InstanceIndices;
			this.ComponentName = ComponentName;
		}

		// Token: 0x06019367 RID: 103271 RVA: 0x00254C5F File Offset: 0x00252E5F
		protected override IntPtr GetUStructPtr()
		{
			return FGrassInstanceData.StaticStruct();
		}

		// Token: 0x06019368 RID: 103272 RVA: 0x00254C6B File Offset: 0x00252E6B
		[NullableContext(2)]
		public FGrassInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019369 RID: 103273 RVA: 0x00254C75 File Offset: 0x00252E75
		public FGrassInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601936A RID: 103274 RVA: 0x00254C80 File Offset: 0x00252E80
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGrassInstanceData(Pointer, false, true);
		}

		// Token: 0x0601936B RID: 103275 RVA: 0x00254C8A File Offset: 0x00252E8A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGrassInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400DC0D RID: 56333
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.GrassInstanceData";

		// Token: 0x0400DC0E RID: 56334
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DC0F RID: 56335
		internal static int __PropertyOffset_HISM;

		// Token: 0x0400DC10 RID: 56336
		internal static int __PropertyOffset_InstanceIndices;

		// Token: 0x0400DC11 RID: 56337
		[Nullable(2)]
		private TArray<int> _InstanceIndices;

		// Token: 0x0400DC12 RID: 56338
		internal static int __PropertyOffset_ComponentName;
	}
}
