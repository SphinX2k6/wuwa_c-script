using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAB RID: 3499
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCustomWpoOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionCustomWpoOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE69 RID: 48745 RVA: 0x00110AB9 File Offset: 0x0010ECB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCustomWpoOutput._ClassPtr;
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x00110AC8 File Offset: 0x0010ECC8
		public UMaterialExpressionCustomWpoOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCustomWpoOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x00110AF0 File Offset: 0x0010ECF0
		public UMaterialExpressionCustomWpoOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCustomWpoOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600BE6C RID: 48748 RVA: 0x00110B24 File Offset: 0x0010ED24
		// (set) Token: 0x0600BE6D RID: 48749 RVA: 0x00110B5D File Offset: 0x0010ED5D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCustomWpoOutput.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCustomWpoOutput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x00110B7E File Offset: 0x0010ED7E
		static UMaterialExpressionCustomWpoOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCustomWpoOutput");
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x00110B8C File Offset: 0x0010ED8C
		protected UMaterialExpressionCustomWpoOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064A5 RID: 25765
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCustomWpoOutput";

		// Token: 0x040064A6 RID: 25766
		private static IntPtr _ClassPtr;

		// Token: 0x040064A7 RID: 25767
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064A8 RID: 25768
		internal static int __PropertyOffset_Input;

		// Token: 0x040064A9 RID: 25769
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
