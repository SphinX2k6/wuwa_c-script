using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D55 RID: 3413
	[UnrealObjectPath("/Script/Engine.LightmassPointLightSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLightmassPointLightSettings : FLightmassLightSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B837 RID: 47159 RVA: 0x001062BC File Offset: 0x001044BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassPointLightSettings._ScriptStructPtr != 0) ? FLightmassPointLightSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassPointLightSettings", ref FLightmassPointLightSettings._ScriptStructPtr);
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x001062E0 File Offset: 0x001044E0
		public FLightmassPointLightSettings()
		{
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x001062E8 File Offset: 0x001044E8
		public FLightmassPointLightSettings(float IndirectLightingSaturation, float ShadowExponent, bool bUseAreaShadowsForStationaryLight)
		{
			base.IndirectLightingSaturation = IndirectLightingSaturation;
			base.ShadowExponent = ShadowExponent;
			base.bUseAreaShadowsForStationaryLight = bUseAreaShadowsForStationaryLight;
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x00106305 File Offset: 0x00104505
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassPointLightSettings.StaticStruct();
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x00106311 File Offset: 0x00104511
		[NullableContext(2)]
		public FLightmassPointLightSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x0010631B File Offset: 0x0010451B
		public FLightmassPointLightSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x00106326 File Offset: 0x00104526
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassPointLightSettings(Pointer, false, true);
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x00106330 File Offset: 0x00104530
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassPointLightSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006089 RID: 24713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassPointLightSettings";

		// Token: 0x0400608A RID: 24714
		private static IntPtr _ScriptStructPtr;
	}
}
