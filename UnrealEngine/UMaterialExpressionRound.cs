using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2C RID: 3628
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRound")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionRound : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C312 RID: 49938 RVA: 0x00119819 File Offset: 0x00117A19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRound._ClassPtr;
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x00119828 File Offset: 0x00117A28
		public UMaterialExpressionRound() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x00119850 File Offset: 0x00117A50
		public UMaterialExpressionRound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600C315 RID: 49941 RVA: 0x00119884 File Offset: 0x00117A84
		// (set) Token: 0x0600C316 RID: 49942 RVA: 0x001198BD File Offset: 0x00117ABD
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRound.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRound.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x001198DE File Offset: 0x00117ADE
		static UMaterialExpressionRound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRound");
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x001198EC File Offset: 0x00117AEC
		protected UMaterialExpressionRound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067F2 RID: 26610
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRound";

		// Token: 0x040067F3 RID: 26611
		private static IntPtr _ClassPtr;

		// Token: 0x040067F4 RID: 26612
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067F5 RID: 26613
		internal static int __PropertyOffset_Input;

		// Token: 0x040067F6 RID: 26614
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
