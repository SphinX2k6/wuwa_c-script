using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200092E RID: 2350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CheckBoxStyleAsset")]
	[UnrealStructLayout(1736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1736)]
	public class UCheckBoxStyleAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084DA RID: 34010 RVA: 0x000BD78D File Offset: 0x000BB98D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckBoxStyleAsset._ClassPtr;
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x000BD79C File Offset: 0x000BB99C
		public UCheckBoxStyleAsset() : this(BuiltinUtils.AllocNativeUObject(UCheckBoxStyleAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		public UCheckBoxStyleAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckBoxStyleAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
		// (set) Token: 0x060084DE RID: 34014 RVA: 0x000BD831 File Offset: 0x000BBA31
		public FCheckBoxStyle CheckBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FCheckBoxStyle result;
				if ((result = this._CheckBoxStyle) == null)
				{
					result = (this._CheckBoxStyle = new FCheckBoxStyle(base.NativePtr + (IntPtr)UCheckBoxStyleAsset.__PropertyOffset_CheckBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCheckBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UCheckBoxStyleAsset.__PropertyOffset_CheckBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x000BD852 File Offset: 0x000BBA52
		static UCheckBoxStyleAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CheckBoxStyleAsset");
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x000BD860 File Offset: 0x000BBA60
		protected UCheckBoxStyleAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F39 RID: 16185
		public new const string __ObjectPath = "/Script/Engine.CheckBoxStyleAsset";

		// Token: 0x04003F3A RID: 16186
		private static IntPtr _ClassPtr;

		// Token: 0x04003F3B RID: 16187
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F3C RID: 16188
		internal static int __PropertyOffset_CheckBoxStyle;

		// Token: 0x04003F3D RID: 16189
		[Nullable(2)]
		private FCheckBoxStyle _CheckBoxStyle;
	}
}
