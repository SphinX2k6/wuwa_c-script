using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E6 RID: 8678
	[UnrealObjectPath("/Script/LGUI.WwiseAudioComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UWwiseAudioComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602118C RID: 135564 RVA: 0x0030CE40 File Offset: 0x0030B040
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseAudioComponent._ClassPtr;
		}

		// Token: 0x0602118D RID: 135565 RVA: 0x0030CE4C File Offset: 0x0030B04C
		public UWwiseAudioComponent() : this(BuiltinUtils.AllocNativeUObject(UWwiseAudioComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602118E RID: 135566 RVA: 0x0030CE74 File Offset: 0x0030B074
		[NullableContext(1)]
		public UWwiseAudioComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseAudioComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008132 RID: 33074
		// (get) Token: 0x0602118F RID: 135567 RVA: 0x0030CEA7 File Offset: 0x0030B0A7
		// (set) Token: 0x06021190 RID: 135568 RVA: 0x0030CEB7 File Offset: 0x0030B0B7
		public unsafe int AudioStateSystemLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseAudioComponent.__PropertyOffset_AudioStateSystemLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseAudioComponent.__PropertyOffset_AudioStateSystemLevel) = value;
			}
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x0030CEC8 File Offset: 0x0030B0C8
		public int GetAudioStateSystemLevel()
		{
			return UWwiseAudioComponent.__GetAudioStateSystemLevel_Internal(base.NativePtr);
		}

		// Token: 0x06021192 RID: 135570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioStateSystemLevel_Internal(IntPtr @this);

		// Token: 0x06021193 RID: 135571 RVA: 0x0030CED5 File Offset: 0x0030B0D5
		static UWwiseAudioComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.WwiseAudioComponent");
		}

		// Token: 0x06021194 RID: 135572 RVA: 0x0030CEE3 File Offset: 0x0030B0E3
		protected UWwiseAudioComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A7A RID: 72314
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.WwiseAudioComponent";

		// Token: 0x04011A7B RID: 72315
		private static IntPtr _ClassPtr;

		// Token: 0x04011A7C RID: 72316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A7D RID: 72317
		internal static int __PropertyOffset_AudioStateSystemLevel;
	}
}
