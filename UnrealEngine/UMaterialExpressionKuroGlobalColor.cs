using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD9 RID: 3545
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroGlobalColor")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionKuroGlobalColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C025 RID: 49189 RVA: 0x00113F95 File Offset: 0x00112195
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroGlobalColor._ClassPtr;
		}

		// Token: 0x0600C026 RID: 49190 RVA: 0x00113FA4 File Offset: 0x001121A4
		public UMaterialExpressionKuroGlobalColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x00113FCC File Offset: 0x001121CC
		public UMaterialExpressionKuroGlobalColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600C028 RID: 49192 RVA: 0x00114000 File Offset: 0x00112200
		// (set) Token: 0x0600C029 RID: 49193 RVA: 0x00114039 File Offset: 0x00112239
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalColor.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalColor.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x0011405A File Offset: 0x0011225A
		static UMaterialExpressionKuroGlobalColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroGlobalColor");
		}

		// Token: 0x0600C02B RID: 49195 RVA: 0x00114068 File Offset: 0x00112268
		protected UMaterialExpressionKuroGlobalColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065E0 RID: 26080
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroGlobalColor";

		// Token: 0x040065E1 RID: 26081
		private static IntPtr _ClassPtr;

		// Token: 0x040065E2 RID: 26082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065E3 RID: 26083
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x040065E4 RID: 26084
		[Nullable(2)]
		private FExpressionInput _WorldPosition;
	}
}
