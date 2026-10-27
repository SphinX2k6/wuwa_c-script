using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002686 RID: 9862
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.DebugViewTexelDensitySettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UDebugViewTexelDensitySettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249F1 RID: 150001 RVA: 0x003637C3 File Offset: 0x003619C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDebugViewTexelDensitySettings._ClassPtr;
		}

		// Token: 0x060249F2 RID: 150002 RVA: 0x003637D0 File Offset: 0x003619D0
		public UDebugViewTexelDensitySettings() : this(BuiltinUtils.AllocNativeUObject(UDebugViewTexelDensitySettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249F3 RID: 150003 RVA: 0x003637F8 File Offset: 0x003619F8
		public UDebugViewTexelDensitySettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDebugViewTexelDensitySettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D34 RID: 36148
		// (get) Token: 0x060249F4 RID: 150004 RVA: 0x0036382C File Offset: 0x00361A2C
		// (set) Token: 0x060249F5 RID: 150005 RVA: 0x00363865 File Offset: 0x00361A65
		public TArray<string> AutoTextureNameRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AutoTextureNameRegex) == null)
				{
					result = (this._AutoTextureNameRegex = new TArray<string>(base.NativePtr + (IntPtr)UDebugViewTexelDensitySettings.__PropertyOffset_AutoTextureNameRegex, this));
				}
				return result;
			}
			set
			{
				this.AutoTextureNameRegex.CopyAssign(value);
			}
		}

		// Token: 0x17008D35 RID: 36149
		// (get) Token: 0x060249F6 RID: 150006 RVA: 0x00363873 File Offset: 0x00361A73
		// (set) Token: 0x060249F7 RID: 150007 RVA: 0x00363883 File Offset: 0x00361A83
		public unsafe float BaseDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDebugViewTexelDensitySettings.__PropertyOffset_BaseDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDebugViewTexelDensitySettings.__PropertyOffset_BaseDensity) = value;
			}
		}

		// Token: 0x17008D36 RID: 36150
		// (get) Token: 0x060249F8 RID: 150008 RVA: 0x00363894 File Offset: 0x00361A94
		// (set) Token: 0x060249F9 RID: 150009 RVA: 0x003638CD File Offset: 0x00361ACD
		public TArray<FLinearColor> DensityColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._DensityColors) == null)
				{
					result = (this._DensityColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UDebugViewTexelDensitySettings.__PropertyOffset_DensityColors, this));
				}
				return result;
			}
			set
			{
				this.DensityColors.CopyAssign(value);
			}
		}

		// Token: 0x060249FA RID: 150010 RVA: 0x003638DB File Offset: 0x00361ADB
		static UDebugViewTexelDensitySettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.DebugViewTexelDensitySettings");
		}

		// Token: 0x060249FB RID: 150011 RVA: 0x003638E9 File Offset: 0x00361AE9
		protected UDebugViewTexelDensitySettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013AEF RID: 80623
		public new const string __ObjectPath = "/Script/Renderer.DebugViewTexelDensitySettings";

		// Token: 0x04013AF0 RID: 80624
		private static IntPtr _ClassPtr;

		// Token: 0x04013AF1 RID: 80625
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013AF2 RID: 80626
		internal static int __PropertyOffset_AutoTextureNameRegex;

		// Token: 0x04013AF3 RID: 80627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AutoTextureNameRegex;

		// Token: 0x04013AF4 RID: 80628
		internal static int __PropertyOffset_BaseDensity;

		// Token: 0x04013AF5 RID: 80629
		internal static int __PropertyOffset_DensityColors;

		// Token: 0x04013AF6 RID: 80630
		[Nullable(2)]
		private TArray<FLinearColor> _DensityColors;
	}
}
