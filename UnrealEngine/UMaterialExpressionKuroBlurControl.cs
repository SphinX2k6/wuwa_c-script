using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD8 RID: 3544
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroBlurControl")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMaterialExpressionKuroBlurControl : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C01A RID: 49178 RVA: 0x00113E01 File Offset: 0x00112001
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroBlurControl._ClassPtr;
		}

		// Token: 0x0600C01B RID: 49179 RVA: 0x00113E10 File Offset: 0x00112010
		public UMaterialExpressionKuroBlurControl() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroBlurControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x00113E38 File Offset: 0x00112038
		public UMaterialExpressionKuroBlurControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroBlurControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600C01D RID: 49181 RVA: 0x00113E6C File Offset: 0x0011206C
		// (set) Token: 0x0600C01E RID: 49182 RVA: 0x00113EA5 File Offset: 0x001120A5
		public FExpressionInput Flow
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Flow) == null)
				{
					result = (this._Flow = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Flow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Flow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600C01F RID: 49183 RVA: 0x00113EC8 File Offset: 0x001120C8
		// (set) Token: 0x0600C020 RID: 49184 RVA: 0x00113F01 File Offset: 0x00112101
		public FExpressionInput Mask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Mask) == null)
				{
					result = (this._Mask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Mask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Mask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600C021 RID: 49185 RVA: 0x00113F24 File Offset: 0x00112124
		// (set) Token: 0x0600C022 RID: 49186 RVA: 0x00113F5D File Offset: 0x0011215D
		public FExpressionInput Modulation
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Modulation) == null)
				{
					result = (this._Modulation = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Modulation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroBlurControl.__PropertyOffset_Modulation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C023 RID: 49187 RVA: 0x00113F7E File Offset: 0x0011217E
		static UMaterialExpressionKuroBlurControl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroBlurControl");
		}

		// Token: 0x0600C024 RID: 49188 RVA: 0x00113F8C File Offset: 0x0011218C
		protected UMaterialExpressionKuroBlurControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065D7 RID: 26071
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroBlurControl";

		// Token: 0x040065D8 RID: 26072
		private static IntPtr _ClassPtr;

		// Token: 0x040065D9 RID: 26073
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065DA RID: 26074
		internal static int __PropertyOffset_Flow;

		// Token: 0x040065DB RID: 26075
		[Nullable(2)]
		private FExpressionInput _Flow;

		// Token: 0x040065DC RID: 26076
		internal static int __PropertyOffset_Mask;

		// Token: 0x040065DD RID: 26077
		[Nullable(2)]
		private FExpressionInput _Mask;

		// Token: 0x040065DE RID: 26078
		internal static int __PropertyOffset_Modulation;

		// Token: 0x040065DF RID: 26079
		[Nullable(2)]
		private FExpressionInput _Modulation;
	}
}
