using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C23 RID: 7203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.RayTracingSettings")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FRayTracingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BD49 RID: 113993 RVA: 0x0028F66C File Offset: 0x0028D86C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRayTracingSettings._ScriptStructPtr != 0) ? FRayTracingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.RayTracingSettings", ref FRayTracingSettings._ScriptStructPtr);
		}

		// Token: 0x17007053 RID: 28755
		// (get) Token: 0x0601BD4A RID: 113994 RVA: 0x0028F690 File Offset: 0x0028D890
		// (set) Token: 0x0601BD4B RID: 113995 RVA: 0x0028F6D3 File Offset: 0x0028D8D3
		public FLumenGISettings LumenGISettings
		{
			get
			{
				base.FastCheckIsValid();
				FLumenGISettings result;
				if ((result = this._LumenGISettings) == null)
				{
					result = (this._LumenGISettings = new FLumenGISettings(base.NativePtr + (IntPtr)FRayTracingSettings.__PropertyOffset_LumenGISettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLumenGISettings.StaticStruct(), base.NativePtr + (IntPtr)FRayTracingSettings.__PropertyOffset_LumenGISettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601BD4C RID: 113996 RVA: 0x0028F6F4 File Offset: 0x0028D8F4
		public FRayTracingSettings()
		{
		}

		// Token: 0x0601BD4D RID: 113997 RVA: 0x0028F6FC File Offset: 0x0028D8FC
		public FRayTracingSettings(FLumenGISettings LumenGISettings)
		{
			this.LumenGISettings = LumenGISettings;
		}

		// Token: 0x0601BD4E RID: 113998 RVA: 0x0028F70B File Offset: 0x0028D90B
		protected override IntPtr GetUStructPtr()
		{
			return FRayTracingSettings.StaticStruct();
		}

		// Token: 0x0601BD4F RID: 113999 RVA: 0x0028F717 File Offset: 0x0028D917
		[NullableContext(2)]
		public FRayTracingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD50 RID: 114000 RVA: 0x0028F721 File Offset: 0x0028D921
		public FRayTracingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD51 RID: 114001 RVA: 0x0028F72C File Offset: 0x0028D92C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRayTracingSettings(Pointer, false, true);
		}

		// Token: 0x0601BD52 RID: 114002 RVA: 0x0028F736 File Offset: 0x0028D936
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRayTracingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF4F RID: 61263
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.RayTracingSettings";

		// Token: 0x0400EF50 RID: 61264
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF51 RID: 61265
		internal static int __PropertyOffset_LumenGISettings;

		// Token: 0x0400EF52 RID: 61266
		[Nullable(2)]
		private FLumenGISettings _LumenGISettings;
	}
}
