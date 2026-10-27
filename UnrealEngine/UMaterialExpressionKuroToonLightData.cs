using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE3 RID: 3555
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroToonLightData")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionKuroToonLightData : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C065 RID: 49253 RVA: 0x00114696 File Offset: 0x00112896
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroToonLightData._ClassPtr;
		}

		// Token: 0x0600C066 RID: 49254 RVA: 0x001146A4 File Offset: 0x001128A4
		public UMaterialExpressionKuroToonLightData() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroToonLightData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x001146CC File Offset: 0x001128CC
		public UMaterialExpressionKuroToonLightData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroToonLightData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600C068 RID: 49256 RVA: 0x00114700 File Offset: 0x00112900
		// (set) Token: 0x0600C069 RID: 49257 RVA: 0x00114739 File Offset: 0x00112939
		public FExpressionInput LightIndex
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LightIndex) == null)
				{
					result = (this._LightIndex = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonLightData.__PropertyOffset_LightIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonLightData.__PropertyOffset_LightIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x0011475A File Offset: 0x0011295A
		static UMaterialExpressionKuroToonLightData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroToonLightData");
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x00114768 File Offset: 0x00112968
		protected UMaterialExpressionKuroToonLightData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400660A RID: 26122
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroToonLightData";

		// Token: 0x0400660B RID: 26123
		private static IntPtr _ClassPtr;

		// Token: 0x0400660C RID: 26124
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400660D RID: 26125
		internal static int __PropertyOffset_LightIndex;

		// Token: 0x0400660E RID: 26126
		[Nullable(2)]
		private FExpressionInput _LightIndex;
	}
}
