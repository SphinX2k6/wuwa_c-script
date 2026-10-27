using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D47 RID: 3399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LightCullDistanceCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLightCullDistanceCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B782 RID: 46978 RVA: 0x00105121 File Offset: 0x00103321
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightCullDistanceCheck._ScriptStructPtr != 0) ? FLightCullDistanceCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightCullDistanceCheck", ref FLightCullDistanceCheck._ScriptStructPtr);
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600B783 RID: 46979 RVA: 0x00105148 File Offset: 0x00103348
		// (set) Token: 0x0600B784 RID: 46980 RVA: 0x0010518B File Offset: 0x0010338B
		public TArray<FLightCullDistanceConfig> LightCullDistanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLightCullDistanceConfig> result;
				if ((result = this._LightCullDistanceConfig) == null)
				{
					result = (this._LightCullDistanceConfig = new TArray<FLightCullDistanceConfig>(base.NativePtr + (IntPtr)FLightCullDistanceCheck.__PropertyOffset_LightCullDistanceConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LightCullDistanceConfig.CopyAssign(value);
			}
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x00105199 File Offset: 0x00103399
		public FLightCullDistanceCheck()
		{
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x001051A1 File Offset: 0x001033A1
		public FLightCullDistanceCheck(TArray<FLightCullDistanceConfig> LightCullDistanceConfig)
		{
			this.LightCullDistanceConfig = LightCullDistanceConfig;
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x001051B0 File Offset: 0x001033B0
		protected override IntPtr GetUStructPtr()
		{
			return FLightCullDistanceCheck.StaticStruct();
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x001051BC File Offset: 0x001033BC
		[NullableContext(2)]
		public FLightCullDistanceCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x001051C6 File Offset: 0x001033C6
		public FLightCullDistanceCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x001051D1 File Offset: 0x001033D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightCullDistanceCheck(Pointer, false, true);
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x001051DB File Offset: 0x001033DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightCullDistanceCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04006020 RID: 24608
		public const string __ObjectPath = "/Script/Engine.LightCullDistanceCheck";

		// Token: 0x04006021 RID: 24609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006022 RID: 24610
		internal static int __PropertyOffset_LightCullDistanceConfig;

		// Token: 0x04006023 RID: 24611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLightCullDistanceConfig> _LightCullDistanceConfig;
	}
}
