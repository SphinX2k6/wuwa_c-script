using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E74 RID: 3700
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexInterpolator")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMaterialExpressionVertexInterpolator : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5CF RID: 50639 RVA: 0x0011E786 File Offset: 0x0011C986
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexInterpolator._ClassPtr;
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x0011E794 File Offset: 0x0011C994
		public UMaterialExpressionVertexInterpolator() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexInterpolator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x0011E7BC File Offset: 0x0011C9BC
		public UMaterialExpressionVertexInterpolator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexInterpolator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600C5D2 RID: 50642 RVA: 0x0011E7F0 File Offset: 0x0011C9F0
		// (set) Token: 0x0600C5D3 RID: 50643 RVA: 0x0011E829 File Offset: 0x0011CA29
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVertexInterpolator.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVertexInterpolator.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x0011E84A File Offset: 0x0011CA4A
		static UMaterialExpressionVertexInterpolator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexInterpolator");
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x0011E858 File Offset: 0x0011CA58
		protected UMaterialExpressionVertexInterpolator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069D6 RID: 27094
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexInterpolator";

		// Token: 0x040069D7 RID: 27095
		private static IntPtr _ClassPtr;

		// Token: 0x040069D8 RID: 27096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069D9 RID: 27097
		internal static int __PropertyOffset_Input;

		// Token: 0x040069DA RID: 27098
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
