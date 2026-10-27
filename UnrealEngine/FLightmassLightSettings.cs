using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D53 RID: 3411
	[UnrealObjectPath("/Script/Engine.LightmassLightSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLightmassLightSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B811 RID: 47121 RVA: 0x00105F5A File Offset: 0x0010415A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassLightSettings._ScriptStructPtr != 0) ? FLightmassLightSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassLightSettings", ref FLightmassLightSettings._ScriptStructPtr);
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x00105F7E File Offset: 0x0010417E
		// (set) Token: 0x0600B813 RID: 47123 RVA: 0x00105F8E File Offset: 0x0010418E
		public unsafe float IndirectLightingSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_IndirectLightingSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_IndirectLightingSaturation) = value;
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x00105F9F File Offset: 0x0010419F
		// (set) Token: 0x0600B815 RID: 47125 RVA: 0x00105FAF File Offset: 0x001041AF
		public unsafe float ShadowExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_ShadowExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_ShadowExponent) = value;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600B816 RID: 47126 RVA: 0x00105FC0 File Offset: 0x001041C0
		// (set) Token: 0x0600B817 RID: 47127 RVA: 0x00105FD0 File Offset: 0x001041D0
		public unsafe bool bUseAreaShadowsForStationaryLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_bUseAreaShadowsForStationaryLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassLightSettings.__PropertyOffset_bUseAreaShadowsForStationaryLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x00105FE1 File Offset: 0x001041E1
		public FLightmassLightSettings()
		{
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x00105FE9 File Offset: 0x001041E9
		public FLightmassLightSettings(float IndirectLightingSaturation, float ShadowExponent, bool bUseAreaShadowsForStationaryLight)
		{
			this.IndirectLightingSaturation = IndirectLightingSaturation;
			this.ShadowExponent = ShadowExponent;
			this.bUseAreaShadowsForStationaryLight = bUseAreaShadowsForStationaryLight;
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x00106006 File Offset: 0x00104206
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassLightSettings.StaticStruct();
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x00106012 File Offset: 0x00104212
		[NullableContext(2)]
		public FLightmassLightSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x0010601C File Offset: 0x0010421C
		public FLightmassLightSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x00106027 File Offset: 0x00104227
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassLightSettings(Pointer, false, true);
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x00106031 File Offset: 0x00104231
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassLightSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006075 RID: 24693
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightmassLightSettings";

		// Token: 0x04006076 RID: 24694
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006077 RID: 24695
		internal static int __PropertyOffset_IndirectLightingSaturation;

		// Token: 0x04006078 RID: 24696
		internal static int __PropertyOffset_ShadowExponent;

		// Token: 0x04006079 RID: 24697
		internal static int __PropertyOffset_bUseAreaShadowsForStationaryLight;
	}
}
