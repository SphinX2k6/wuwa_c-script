using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D84 RID: 3460
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArccosine")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArccosine : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD0C RID: 48396 RVA: 0x0010E3A9 File Offset: 0x0010C5A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArccosine._ClassPtr;
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x0010E3B8 File Offset: 0x0010C5B8
		public UMaterialExpressionArccosine() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArccosine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x0010E3E0 File Offset: 0x0010C5E0
		public UMaterialExpressionArccosine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArccosine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x0010E414 File Offset: 0x0010C614
		// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x0010E44D File Offset: 0x0010C64D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArccosine.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArccosine.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x0010E46E File Offset: 0x0010C66E
		static UMaterialExpressionArccosine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArccosine");
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x0010E47C File Offset: 0x0010C67C
		protected UMaterialExpressionArccosine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063B5 RID: 25525
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArccosine";

		// Token: 0x040063B6 RID: 25526
		private static IntPtr _ClassPtr;

		// Token: 0x040063B7 RID: 25527
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063B8 RID: 25528
		internal static int __PropertyOffset_Input;

		// Token: 0x040063B9 RID: 25529
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
