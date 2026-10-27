using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D99 RID: 3481
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCeil")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionCeil : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDB8 RID: 48568 RVA: 0x0010F816 File Offset: 0x0010DA16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCeil._ClassPtr;
		}

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x0010F824 File Offset: 0x0010DA24
		public UMaterialExpressionCeil() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCeil.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDBA RID: 48570 RVA: 0x0010F84C File Offset: 0x0010DA4C
		public UMaterialExpressionCeil(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCeil.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x0010F880 File Offset: 0x0010DA80
		// (set) Token: 0x0600BDBC RID: 48572 RVA: 0x0010F8B9 File Offset: 0x0010DAB9
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCeil.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCeil.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x0010F8DA File Offset: 0x0010DADA
		static UMaterialExpressionCeil()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCeil");
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x0010F8E8 File Offset: 0x0010DAE8
		protected UMaterialExpressionCeil(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006430 RID: 25648
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCeil";

		// Token: 0x04006431 RID: 25649
		private static IntPtr _ClassPtr;

		// Token: 0x04006432 RID: 25650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006433 RID: 25651
		internal static int __PropertyOffset_Input;

		// Token: 0x04006434 RID: 25652
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
