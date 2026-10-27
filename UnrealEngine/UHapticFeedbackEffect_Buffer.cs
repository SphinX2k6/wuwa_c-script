using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C16 RID: 3094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HapticFeedbackEffect_Buffer")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UHapticFeedbackEffect_Buffer : UHapticFeedbackEffect_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C60 RID: 40032 RVA: 0x000DE5CE File Offset: 0x000DC7CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHapticFeedbackEffect_Buffer._ClassPtr;
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x000DE5DC File Offset: 0x000DC7DC
		public UHapticFeedbackEffect_Buffer() : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Buffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x000DE604 File Offset: 0x000DC804
		public UHapticFeedbackEffect_Buffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Buffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x06009C63 RID: 40035 RVA: 0x000DE638 File Offset: 0x000DC838
		// (set) Token: 0x06009C64 RID: 40036 RVA: 0x000DE671 File Offset: 0x000DC871
		public TArray<byte> Amplitudes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Amplitudes) == null)
				{
					result = (this._Amplitudes = new TArray<byte>(base.NativePtr + (IntPtr)UHapticFeedbackEffect_Buffer.__PropertyOffset_Amplitudes, this));
				}
				return result;
			}
			set
			{
				this.Amplitudes.CopyAssign(value);
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x000DE67F File Offset: 0x000DC87F
		// (set) Token: 0x06009C66 RID: 40038 RVA: 0x000DE68F File Offset: 0x000DC88F
		public unsafe int SampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHapticFeedbackEffect_Buffer.__PropertyOffset_SampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHapticFeedbackEffect_Buffer.__PropertyOffset_SampleRate) = value;
			}
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x000DE6A0 File Offset: 0x000DC8A0
		static UHapticFeedbackEffect_Buffer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HapticFeedbackEffect_Buffer");
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x000DE6AE File Offset: 0x000DC8AE
		protected UHapticFeedbackEffect_Buffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400564E RID: 22094
		public new const string __ObjectPath = "/Script/Engine.HapticFeedbackEffect_Buffer";

		// Token: 0x0400564F RID: 22095
		private static IntPtr _ClassPtr;

		// Token: 0x04005650 RID: 22096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005651 RID: 22097
		internal static int __PropertyOffset_Amplitudes;

		// Token: 0x04005652 RID: 22098
		[Nullable(2)]
		private TArray<byte> _Amplitudes;

		// Token: 0x04005653 RID: 22099
		internal static int __PropertyOffset_SampleRate;
	}
}
