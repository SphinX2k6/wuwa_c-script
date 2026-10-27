using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008FE RID: 2302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ButtonStyleAsset")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UButtonStyleAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E66 RID: 32358 RVA: 0x000B56D9 File Offset: 0x000B38D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UButtonStyleAsset._ClassPtr;
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x000B56E8 File Offset: 0x000B38E8
		public UButtonStyleAsset() : this(BuiltinUtils.AllocNativeUObject(UButtonStyleAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x000B5710 File Offset: 0x000B3910
		public UButtonStyleAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UButtonStyleAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x000B5744 File Offset: 0x000B3944
		// (set) Token: 0x06007E6A RID: 32362 RVA: 0x000B577D File Offset: 0x000B397D
		public FButtonStyle ButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._ButtonStyle) == null)
				{
					result = (this._ButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)UButtonStyleAsset.__PropertyOffset_ButtonStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)UButtonStyleAsset.__PropertyOffset_ButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x000B579E File Offset: 0x000B399E
		static UButtonStyleAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ButtonStyleAsset");
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x000B57AC File Offset: 0x000B39AC
		protected UButtonStyleAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CAB RID: 15531
		public new const string __ObjectPath = "/Script/Engine.ButtonStyleAsset";

		// Token: 0x04003CAC RID: 15532
		private static IntPtr _ClassPtr;

		// Token: 0x04003CAD RID: 15533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CAE RID: 15534
		internal static int __PropertyOffset_ButtonStyle;

		// Token: 0x04003CAF RID: 15535
		[Nullable(2)]
		private FButtonStyle _ButtonStyle;
	}
}
