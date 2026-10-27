using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001754 RID: 5972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.GpuNpcAvoidComponent")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UGpuNpcAvoidComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601574C RID: 87884 RVA: 0x001F8814 File Offset: 0x001F6A14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGpuNpcAvoidComponent._ClassPtr;
		}

		// Token: 0x0601574D RID: 87885 RVA: 0x001F8820 File Offset: 0x001F6A20
		public UGpuNpcAvoidComponent() : this(BuiltinUtils.AllocNativeUObject(UGpuNpcAvoidComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x001F8848 File Offset: 0x001F6A48
		public UGpuNpcAvoidComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGpuNpcAvoidComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x0601574F RID: 87887 RVA: 0x001F887C File Offset: 0x001F6A7C
		// (set) Token: 0x06015750 RID: 87888 RVA: 0x001F88B5 File Offset: 0x001F6AB5
		public TArray<FGpuNpcConfig> GpuNpcCongifs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGpuNpcConfig> result;
				if ((result = this._GpuNpcCongifs) == null)
				{
					result = (this._GpuNpcCongifs = new TArray<FGpuNpcConfig>(base.NativePtr + (IntPtr)UGpuNpcAvoidComponent.__PropertyOffset_GpuNpcCongifs, this));
				}
				return result;
			}
			set
			{
				this.GpuNpcCongifs.CopyAssign(value);
			}
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x06015751 RID: 87889 RVA: 0x001F88C3 File Offset: 0x001F6AC3
		// (set) Token: 0x06015752 RID: 87890 RVA: 0x001F88D3 File Offset: 0x001F6AD3
		public unsafe float AvoidDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcAvoidComponent.__PropertyOffset_AvoidDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcAvoidComponent.__PropertyOffset_AvoidDistanceMin) = value;
			}
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x06015753 RID: 87891 RVA: 0x001F88E4 File Offset: 0x001F6AE4
		// (set) Token: 0x06015754 RID: 87892 RVA: 0x001F88F4 File Offset: 0x001F6AF4
		public unsafe float AvoidDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcAvoidComponent.__PropertyOffset_AvoidDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcAvoidComponent.__PropertyOffset_AvoidDistanceMax) = value;
			}
		}

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x06015755 RID: 87893 RVA: 0x001F8905 File Offset: 0x001F6B05
		// (set) Token: 0x06015756 RID: 87894 RVA: 0x001F8919 File Offset: 0x001F6B19
		[Nullable(2)]
		public unsafe ACharacter WatchingCharacter
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACharacter>(base.NativePtr / (IntPtr)sizeof(void*) + UGpuNpcAvoidComponent.__PropertyOffset_WatchingCharacter);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGpuNpcAvoidComponent.__PropertyOffset_WatchingCharacter, value);
			}
		}

		// Token: 0x06015757 RID: 87895 RVA: 0x001F892E File Offset: 0x001F6B2E
		public void InitGpuNpcAvoid()
		{
			UGpuNpcAvoidComponent.__InitGpuNpcAvoid_Internal(base.NativePtr);
		}

		// Token: 0x06015758 RID: 87896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitGpuNpcAvoid_Internal(IntPtr @this);

		// Token: 0x06015759 RID: 87897 RVA: 0x001F893B File Offset: 0x001F6B3B
		static UGpuNpcAvoidComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.GpuNpcAvoidComponent");
		}

		// Token: 0x0601575A RID: 87898 RVA: 0x001F8949 File Offset: 0x001F6B49
		protected UGpuNpcAvoidComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB4C RID: 47948
		public new const string __ObjectPath = "/Script/KuroComponent.GpuNpcAvoidComponent";

		// Token: 0x0400BB4D RID: 47949
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB4E RID: 47950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB4F RID: 47951
		internal static int __PropertyOffset_GpuNpcCongifs;

		// Token: 0x0400BB50 RID: 47952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGpuNpcConfig> _GpuNpcCongifs;

		// Token: 0x0400BB51 RID: 47953
		internal static int __PropertyOffset_AvoidDistanceMin;

		// Token: 0x0400BB52 RID: 47954
		internal static int __PropertyOffset_AvoidDistanceMax;

		// Token: 0x0400BB53 RID: 47955
		internal static int __PropertyOffset_WatchingCharacter;
	}
}
