using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8F RID: 3471
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBentNormalCustomOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionBentNormalCustomOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD59 RID: 48473 RVA: 0x0010ED1E File Offset: 0x0010CF1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBentNormalCustomOutput._ClassPtr;
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x0010ED2C File Offset: 0x0010CF2C
		public UMaterialExpressionBentNormalCustomOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBentNormalCustomOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x0010ED54 File Offset: 0x0010CF54
		public UMaterialExpressionBentNormalCustomOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBentNormalCustomOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x0010ED88 File Offset: 0x0010CF88
		// (set) Token: 0x0600BD5D RID: 48477 RVA: 0x0010EDC1 File Offset: 0x0010CFC1
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBentNormalCustomOutput.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBentNormalCustomOutput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x0010EDE2 File Offset: 0x0010CFE2
		static UMaterialExpressionBentNormalCustomOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBentNormalCustomOutput");
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x0010EDF0 File Offset: 0x0010CFF0
		protected UMaterialExpressionBentNormalCustomOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063EC RID: 25580
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBentNormalCustomOutput";

		// Token: 0x040063ED RID: 25581
		private static IntPtr _ClassPtr;

		// Token: 0x040063EE RID: 25582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063EF RID: 25583
		internal static int __PropertyOffset_Input;

		// Token: 0x040063F0 RID: 25584
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
