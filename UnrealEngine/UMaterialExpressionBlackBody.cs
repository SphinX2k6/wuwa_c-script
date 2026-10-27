using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D90 RID: 3472
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBlackBody")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionBlackBody : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD60 RID: 48480 RVA: 0x0010EDF9 File Offset: 0x0010CFF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBlackBody._ClassPtr;
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x0010EE08 File Offset: 0x0010D008
		public UMaterialExpressionBlackBody() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBlackBody.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x0010EE30 File Offset: 0x0010D030
		public UMaterialExpressionBlackBody(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBlackBody.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600BD63 RID: 48483 RVA: 0x0010EE64 File Offset: 0x0010D064
		// (set) Token: 0x0600BD64 RID: 48484 RVA: 0x0010EE9D File Offset: 0x0010D09D
		public FExpressionInput Temp
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Temp) == null)
				{
					result = (this._Temp = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBlackBody.__PropertyOffset_Temp, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBlackBody.__PropertyOffset_Temp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x0010EEBE File Offset: 0x0010D0BE
		static UMaterialExpressionBlackBody()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBlackBody");
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x0010EECC File Offset: 0x0010D0CC
		protected UMaterialExpressionBlackBody(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063F1 RID: 25585
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBlackBody";

		// Token: 0x040063F2 RID: 25586
		private static IntPtr _ClassPtr;

		// Token: 0x040063F3 RID: 25587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063F4 RID: 25588
		internal static int __PropertyOffset_Temp;

		// Token: 0x040063F5 RID: 25589
		[Nullable(2)]
		private FExpressionInput _Temp;
	}
}
