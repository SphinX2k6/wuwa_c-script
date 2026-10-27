using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D50 RID: 3408
	[UnrealObjectPath("/Script/Engine.LightmassDirectionalLightSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLightmassDirectionalLightSettings : FLightmassLightSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B7FD RID: 47101 RVA: 0x00105DB4 File Offset: 0x00103FB4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassDirectionalLightSettings._ScriptStructPtr != 0) ? FLightmassDirectionalLightSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassDirectionalLightSettings", ref FLightmassDirectionalLightSettings._ScriptStructPtr);
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x00105DD8 File Offset: 0x00103FD8
		// (set) Token: 0x0600B7FF RID: 47103 RVA: 0x00105DE8 File Offset: 0x00103FE8
		public unsafe float LightSourceAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassDirectionalLightSettings.__PropertyOffset_LightSourceAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassDirectionalLightSettings.__PropertyOffset_LightSourceAngle) = value;
			}
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x00105DF9 File Offset: 0x00103FF9
		public FLightmassDirectionalLightSettings()
		{
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x00105E01 File Offset: 0x00104001
		public FLightmassDirectionalLightSettings(float LightSourceAngle, float IndirectLightingSaturation, float ShadowExponent, bool bUseAreaShadowsForStationaryLight)
		{
			this.LightSourceAngle = LightSourceAngle;
			base.IndirectLightingSaturation = IndirectLightingSaturation;
			base.ShadowExponent = ShadowExponent;
			base.bUseAreaShadowsForStationaryLight = bUseAreaShadowsForStationaryLight;
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x00105E26 File Offset: 0x00104026
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassDirectionalLightSettings.StaticStruct();
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x00105E32 File Offset: 0x00104032
		[NullableContext(2)]
		public FLightmassDirectionalLightSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x00105E3C File Offset: 0x0010403C
		public FLightmassDirectionalLightSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x00105E47 File Offset: 0x00104047
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassDirectionalLightSettings(Pointer, false, true);
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x00105E51 File Offset: 0x00104051
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassDirectionalLightSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400606C RID: 24684
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassDirectionalLightSettings";

		// Token: 0x0400606D RID: 24685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400606E RID: 24686
		internal static int __PropertyOffset_LightSourceAngle;
	}
}
