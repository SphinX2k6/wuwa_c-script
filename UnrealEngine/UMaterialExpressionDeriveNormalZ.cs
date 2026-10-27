using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB5 RID: 3509
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDeriveNormalZ")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDeriveNormalZ : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEB5 RID: 48821 RVA: 0x00111341 File Offset: 0x0010F541
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDeriveNormalZ._ClassPtr;
		}

		// Token: 0x0600BEB6 RID: 48822 RVA: 0x00111350 File Offset: 0x0010F550
		public UMaterialExpressionDeriveNormalZ() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDeriveNormalZ.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x00111378 File Offset: 0x0010F578
		public UMaterialExpressionDeriveNormalZ(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDeriveNormalZ.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600BEB8 RID: 48824 RVA: 0x001113AC File Offset: 0x0010F5AC
		// (set) Token: 0x0600BEB9 RID: 48825 RVA: 0x001113E5 File Offset: 0x0010F5E5
		public FExpressionInput InXY
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._InXY) == null)
				{
					result = (this._InXY = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDeriveNormalZ.__PropertyOffset_InXY, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDeriveNormalZ.__PropertyOffset_InXY, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x00111406 File Offset: 0x0010F606
		static UMaterialExpressionDeriveNormalZ()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDeriveNormalZ");
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x00111414 File Offset: 0x0010F614
		protected UMaterialExpressionDeriveNormalZ(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064D8 RID: 25816
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDeriveNormalZ";

		// Token: 0x040064D9 RID: 25817
		private static IntPtr _ClassPtr;

		// Token: 0x040064DA RID: 25818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064DB RID: 25819
		internal static int __PropertyOffset_InXY;

		// Token: 0x040064DC RID: 25820
		[Nullable(2)]
		private FExpressionInput _InXY;
	}
}
