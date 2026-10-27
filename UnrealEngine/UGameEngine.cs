using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF9 RID: 3065
	[UnrealObjectPath("/Script/Engine.GameEngine")]
	[UnrealStructLayout(7464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7464)]
	public class UGameEngine : UEngine, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009747 RID: 38727 RVA: 0x000D7A7D File Offset: 0x000D5C7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameEngine._ClassPtr;
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x000D7A8C File Offset: 0x000D5C8C
		public UGameEngine() : this(BuiltinUtils.AllocNativeUObject(UGameEngine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x000D7AB4 File Offset: 0x000D5CB4
		[NullableContext(1)]
		public UGameEngine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameEngine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600974A RID: 38730 RVA: 0x000D7AE7 File Offset: 0x000D5CE7
		// (set) Token: 0x0600974B RID: 38731 RVA: 0x000D7AF7 File Offset: 0x000D5CF7
		public unsafe float MaxDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameEngine.__PropertyOffset_MaxDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameEngine.__PropertyOffset_MaxDeltaTime) = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600974C RID: 38732 RVA: 0x000D7B08 File Offset: 0x000D5D08
		// (set) Token: 0x0600974D RID: 38733 RVA: 0x000D7B18 File Offset: 0x000D5D18
		public unsafe float ServerFlushLogInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameEngine.__PropertyOffset_ServerFlushLogInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameEngine.__PropertyOffset_ServerFlushLogInterval) = value;
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600974E RID: 38734 RVA: 0x000D7B29 File Offset: 0x000D5D29
		// (set) Token: 0x0600974F RID: 38735 RVA: 0x000D7B3D File Offset: 0x000D5D3D
		[Nullable(2)]
		public unsafe UGameInstance GameInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UGameEngine.__PropertyOffset_GameInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameEngine.__PropertyOffset_GameInstance, value);
			}
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x000D7B52 File Offset: 0x000D5D52
		static UGameEngine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameEngine");
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x000D7B60 File Offset: 0x000D5D60
		protected UGameEngine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054C4 RID: 21700
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameEngine";

		// Token: 0x040054C5 RID: 21701
		private static IntPtr _ClassPtr;

		// Token: 0x040054C6 RID: 21702
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054C7 RID: 21703
		internal static int __PropertyOffset_MaxDeltaTime;

		// Token: 0x040054C8 RID: 21704
		internal static int __PropertyOffset_ServerFlushLogInterval;

		// Token: 0x040054C9 RID: 21705
		internal static int __PropertyOffset_GameInstance;
	}
}
