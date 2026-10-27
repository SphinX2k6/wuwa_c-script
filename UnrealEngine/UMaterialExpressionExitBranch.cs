using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC1 RID: 3521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionExitBranch")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionExitBranch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF1B RID: 48923 RVA: 0x00111F27 File Offset: 0x00110127
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionExitBranch._ClassPtr;
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x00111F34 File Offset: 0x00110134
		public UMaterialExpressionExitBranch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionExitBranch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF1D RID: 48925 RVA: 0x00111F5C File Offset: 0x0011015C
		public UMaterialExpressionExitBranch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionExitBranch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600BF1E RID: 48926 RVA: 0x00111F90 File Offset: 0x00110190
		// (set) Token: 0x0600BF1F RID: 48927 RVA: 0x00111FC9 File Offset: 0x001101C9
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionExitBranch.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionExitBranch.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF20 RID: 48928 RVA: 0x00111FEA File Offset: 0x001101EA
		static UMaterialExpressionExitBranch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionExitBranch");
		}

		// Token: 0x0600BF21 RID: 48929 RVA: 0x00111FF8 File Offset: 0x001101F8
		protected UMaterialExpressionExitBranch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400651F RID: 25887
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionExitBranch";

		// Token: 0x04006520 RID: 25888
		private static IntPtr _ClassPtr;

		// Token: 0x04006521 RID: 25889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006522 RID: 25890
		internal static int __PropertyOffset_Input;

		// Token: 0x04006523 RID: 25891
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
