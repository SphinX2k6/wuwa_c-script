using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD6 RID: 3542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionImposterBakeAlphaOutput")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UMaterialExpressionImposterBakeAlphaOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFFA RID: 49146 RVA: 0x001139FA File Offset: 0x00111BFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionImposterBakeAlphaOutput._ClassPtr;
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x00113A08 File Offset: 0x00111C08
		public UMaterialExpressionImposterBakeAlphaOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionImposterBakeAlphaOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x00113A30 File Offset: 0x00111C30
		public UMaterialExpressionImposterBakeAlphaOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionImposterBakeAlphaOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0600BFFD RID: 49149 RVA: 0x00113A64 File Offset: 0x00111C64
		// (set) Token: 0x0600BFFE RID: 49150 RVA: 0x00113A9D File Offset: 0x00111C9D
		public FExpressionInput BakeDiffuse
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BakeDiffuse) == null)
				{
					result = (this._BakeDiffuse = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeDiffuse, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeDiffuse, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600BFFF RID: 49151 RVA: 0x00113AC0 File Offset: 0x00111CC0
		// (set) Token: 0x0600C000 RID: 49152 RVA: 0x00113AF9 File Offset: 0x00111CF9
		public FExpressionInput BakeAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BakeAlpha) == null)
				{
					result = (this._BakeAlpha = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeAlpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeAlpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600C001 RID: 49153 RVA: 0x00113B1C File Offset: 0x00111D1C
		// (set) Token: 0x0600C002 RID: 49154 RVA: 0x00113B55 File Offset: 0x00111D55
		public FExpressionInput BakeHeightAO
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BakeHeightAO) == null)
				{
					result = (this._BakeHeightAO = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeHeightAO, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_BakeHeightAO, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600C003 RID: 49155 RVA: 0x00113B78 File Offset: 0x00111D78
		// (set) Token: 0x0600C004 RID: 49156 RVA: 0x00113BB1 File Offset: 0x00111DB1
		public FExpressionInput UseBakeHeightAO
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._UseBakeHeightAO) == null)
				{
					result = (this._UseBakeHeightAO = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_UseBakeHeightAO, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionImposterBakeAlphaOutput.__PropertyOffset_UseBakeHeightAO, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x00113BD2 File Offset: 0x00111DD2
		static UMaterialExpressionImposterBakeAlphaOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionImposterBakeAlphaOutput");
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x00113BE0 File Offset: 0x00111DE0
		protected UMaterialExpressionImposterBakeAlphaOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065BF RID: 26047
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionImposterBakeAlphaOutput";

		// Token: 0x040065C0 RID: 26048
		private static IntPtr _ClassPtr;

		// Token: 0x040065C1 RID: 26049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065C2 RID: 26050
		internal static int __PropertyOffset_BakeDiffuse;

		// Token: 0x040065C3 RID: 26051
		[Nullable(2)]
		private FExpressionInput _BakeDiffuse;

		// Token: 0x040065C4 RID: 26052
		internal static int __PropertyOffset_BakeAlpha;

		// Token: 0x040065C5 RID: 26053
		[Nullable(2)]
		private FExpressionInput _BakeAlpha;

		// Token: 0x040065C6 RID: 26054
		internal static int __PropertyOffset_BakeHeightAO;

		// Token: 0x040065C7 RID: 26055
		[Nullable(2)]
		private FExpressionInput _BakeHeightAO;

		// Token: 0x040065C8 RID: 26056
		internal static int __PropertyOffset_UseBakeHeightAO;

		// Token: 0x040065C9 RID: 26057
		[Nullable(2)]
		private FExpressionInput _UseBakeHeightAO;
	}
}
