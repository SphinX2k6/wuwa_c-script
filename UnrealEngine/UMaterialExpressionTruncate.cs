using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6F RID: 3695
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTruncate")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionTruncate : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5A2 RID: 50594 RVA: 0x0011E30F File Offset: 0x0011C50F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTruncate._ClassPtr;
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x0011E31C File Offset: 0x0011C51C
		public UMaterialExpressionTruncate() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTruncate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x0011E344 File Offset: 0x0011C544
		public UMaterialExpressionTruncate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTruncate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600C5A5 RID: 50597 RVA: 0x0011E378 File Offset: 0x0011C578
		// (set) Token: 0x0600C5A6 RID: 50598 RVA: 0x0011E3B1 File Offset: 0x0011C5B1
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTruncate.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTruncate.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C5A7 RID: 50599 RVA: 0x0011E3D2 File Offset: 0x0011C5D2
		static UMaterialExpressionTruncate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTruncate");
		}

		// Token: 0x0600C5A8 RID: 50600 RVA: 0x0011E3E0 File Offset: 0x0011C5E0
		protected UMaterialExpressionTruncate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069BA RID: 27066
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTruncate";

		// Token: 0x040069BB RID: 27067
		private static IntPtr _ClassPtr;

		// Token: 0x040069BC RID: 27068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069BD RID: 27069
		internal static int __PropertyOffset_Input;

		// Token: 0x040069BE RID: 27070
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
