using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8C RID: 3468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAtmosphericFogColor")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionAtmosphericFogColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD48 RID: 48456 RVA: 0x0010EB41 File Offset: 0x0010CD41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAtmosphericFogColor._ClassPtr;
		}

		// Token: 0x0600BD49 RID: 48457 RVA: 0x0010EB50 File Offset: 0x0010CD50
		public UMaterialExpressionAtmosphericFogColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericFogColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD4A RID: 48458 RVA: 0x0010EB78 File Offset: 0x0010CD78
		public UMaterialExpressionAtmosphericFogColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericFogColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0600BD4B RID: 48459 RVA: 0x0010EBAC File Offset: 0x0010CDAC
		// (set) Token: 0x0600BD4C RID: 48460 RVA: 0x0010EBE5 File Offset: 0x0010CDE5
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAtmosphericFogColor.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAtmosphericFogColor.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD4D RID: 48461 RVA: 0x0010EC06 File Offset: 0x0010CE06
		static UMaterialExpressionAtmosphericFogColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAtmosphericFogColor");
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x0010EC14 File Offset: 0x0010CE14
		protected UMaterialExpressionAtmosphericFogColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063E1 RID: 25569
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAtmosphericFogColor";

		// Token: 0x040063E2 RID: 25570
		private static IntPtr _ClassPtr;

		// Token: 0x040063E3 RID: 25571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063E4 RID: 25572
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x040063E5 RID: 25573
		[Nullable(2)]
		private FExpressionInput _WorldPosition;
	}
}
