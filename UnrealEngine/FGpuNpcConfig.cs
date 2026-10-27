using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001755 RID: 5973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.GpuNpcConfig")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FGpuNpcConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601575B RID: 87899 RVA: 0x001F8952 File Offset: 0x001F6B52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGpuNpcConfig._ScriptStructPtr != 0) ? FGpuNpcConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.GpuNpcConfig", ref FGpuNpcConfig._ScriptStructPtr);
		}

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x0601575C RID: 87900 RVA: 0x001F8976 File Offset: 0x001F6B76
		// (set) Token: 0x0601575D RID: 87901 RVA: 0x001F8986 File Offset: 0x001F6B86
		public unsafe int MaxState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_MaxState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_MaxState) = value;
			}
		}

		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x0601575E RID: 87902 RVA: 0x001F8997 File Offset: 0x001F6B97
		// (set) Token: 0x0601575F RID: 87903 RVA: 0x001F89A7 File Offset: 0x001F6BA7
		public unsafe float StartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_StartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_StartAngle) = value;
			}
		}

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x06015760 RID: 87904 RVA: 0x001F89B8 File Offset: 0x001F6BB8
		// (set) Token: 0x06015761 RID: 87905 RVA: 0x001F89FB File Offset: 0x001F6BFB
		public TArray<float> AnimEndTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AnimEndTimes) == null)
				{
					result = (this._AnimEndTimes = new TArray<float>(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_AnimEndTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimEndTimes.CopyAssign(value);
			}
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x06015762 RID: 87906 RVA: 0x001F8A0C File Offset: 0x001F6C0C
		// (set) Token: 0x06015763 RID: 87907 RVA: 0x001F8A4F File Offset: 0x001F6C4F
		public TArray<int> StateAnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._StateAnimMap) == null)
				{
					result = (this._StateAnimMap = new TArray<int>(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_StateAnimMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StateAnimMap.CopyAssign(value);
			}
		}

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x06015764 RID: 87908 RVA: 0x001F8A60 File Offset: 0x001F6C60
		// (set) Token: 0x06015765 RID: 87909 RVA: 0x001F8AA3 File Offset: 0x001F6CA3
		public TArray<FGpuNpcTransition> TransitionStateMaps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGpuNpcTransition> result;
				if ((result = this._TransitionStateMaps) == null)
				{
					result = (this._TransitionStateMaps = new TArray<FGpuNpcTransition>(base.NativePtr + (IntPtr)FGpuNpcConfig.__PropertyOffset_TransitionStateMaps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionStateMaps.CopyAssign(value);
			}
		}

		// Token: 0x06015766 RID: 87910 RVA: 0x001F8AB1 File Offset: 0x001F6CB1
		public FGpuNpcConfig()
		{
		}

		// Token: 0x06015767 RID: 87911 RVA: 0x001F8AB9 File Offset: 0x001F6CB9
		public FGpuNpcConfig(int MaxState, float StartAngle, TArray<float> AnimEndTimes, TArray<int> StateAnimMap, TArray<FGpuNpcTransition> TransitionStateMaps)
		{
			this.MaxState = MaxState;
			this.StartAngle = StartAngle;
			this.AnimEndTimes = AnimEndTimes;
			this.StateAnimMap = StateAnimMap;
			this.TransitionStateMaps = TransitionStateMaps;
		}

		// Token: 0x06015768 RID: 87912 RVA: 0x001F8AE6 File Offset: 0x001F6CE6
		protected override IntPtr GetUStructPtr()
		{
			return FGpuNpcConfig.StaticStruct();
		}

		// Token: 0x06015769 RID: 87913 RVA: 0x001F8AF2 File Offset: 0x001F6CF2
		[NullableContext(2)]
		public FGpuNpcConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601576A RID: 87914 RVA: 0x001F8AFC File Offset: 0x001F6CFC
		public FGpuNpcConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601576B RID: 87915 RVA: 0x001F8B07 File Offset: 0x001F6D07
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGpuNpcConfig(Pointer, false, true);
		}

		// Token: 0x0601576C RID: 87916 RVA: 0x001F8B11 File Offset: 0x001F6D11
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGpuNpcConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400BB54 RID: 47956
		public const string __ObjectPath = "/Script/KuroComponent.GpuNpcConfig";

		// Token: 0x0400BB55 RID: 47957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BB56 RID: 47958
		internal static int __PropertyOffset_MaxState;

		// Token: 0x0400BB57 RID: 47959
		internal static int __PropertyOffset_StartAngle;

		// Token: 0x0400BB58 RID: 47960
		internal static int __PropertyOffset_AnimEndTimes;

		// Token: 0x0400BB59 RID: 47961
		[Nullable(2)]
		private TArray<float> _AnimEndTimes;

		// Token: 0x0400BB5A RID: 47962
		internal static int __PropertyOffset_StateAnimMap;

		// Token: 0x0400BB5B RID: 47963
		[Nullable(2)]
		private TArray<int> _StateAnimMap;

		// Token: 0x0400BB5C RID: 47964
		internal static int __PropertyOffset_TransitionStateMaps;

		// Token: 0x0400BB5D RID: 47965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGpuNpcTransition> _TransitionStateMaps;
	}
}
