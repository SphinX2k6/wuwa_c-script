using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000869 RID: 2153
	[UnrealObjectPath("/Script/Engine.AudioComponentParam")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAudioComponentParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060074D8 RID: 29912 RVA: 0x000A78C9 File Offset: 0x000A5AC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioComponentParam._ScriptStructPtr != 0) ? FAudioComponentParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioComponentParam", ref FAudioComponentParam._ScriptStructPtr);
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x060074D9 RID: 29913 RVA: 0x000A78ED File Offset: 0x000A5AED
		// (set) Token: 0x060074DA RID: 29914 RVA: 0x000A7901 File Offset: 0x000A5B01
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x060074DB RID: 29915 RVA: 0x000A7916 File Offset: 0x000A5B16
		// (set) Token: 0x060074DC RID: 29916 RVA: 0x000A7926 File Offset: 0x000A5B26
		public unsafe float FloatParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_FloatParam);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_FloatParam) = value;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x060074DD RID: 29917 RVA: 0x000A7937 File Offset: 0x000A5B37
		// (set) Token: 0x060074DE RID: 29918 RVA: 0x000A7947 File Offset: 0x000A5B47
		public unsafe bool BoolParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_BoolParam) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_BoolParam) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x000A7958 File Offset: 0x000A5B58
		// (set) Token: 0x060074E0 RID: 29920 RVA: 0x000A7968 File Offset: 0x000A5B68
		public unsafe int IntParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_IntParam);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioComponentParam.__PropertyOffset_IntParam) = value;
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x060074E1 RID: 29921 RVA: 0x000A7979 File Offset: 0x000A5B79
		// (set) Token: 0x060074E2 RID: 29922 RVA: 0x000A798D File Offset: 0x000A5B8D
		[Nullable(2)]
		public unsafe USoundWave SoundWaveParam
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + FAudioComponentParam.__PropertyOffset_SoundWaveParam);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAudioComponentParam.__PropertyOffset_SoundWaveParam, value);
			}
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x000A79A2 File Offset: 0x000A5BA2
		public FAudioComponentParam()
		{
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x000A79AA File Offset: 0x000A5BAA
		[NullableContext(1)]
		public FAudioComponentParam(FName ParamName, float FloatParam, bool BoolParam, int IntParam, USoundWave SoundWaveParam)
		{
			this.ParamName = ParamName;
			this.FloatParam = FloatParam;
			this.BoolParam = BoolParam;
			this.IntParam = IntParam;
			this.SoundWaveParam = SoundWaveParam;
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x000A79D7 File Offset: 0x000A5BD7
		protected override IntPtr GetUStructPtr()
		{
			return FAudioComponentParam.StaticStruct();
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x000A79E3 File Offset: 0x000A5BE3
		[NullableContext(2)]
		public FAudioComponentParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x000A79ED File Offset: 0x000A5BED
		public FAudioComponentParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x000A79F8 File Offset: 0x000A5BF8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioComponentParam(Pointer, false, true);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x000A7A02 File Offset: 0x000A5C02
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioComponentParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400382E RID: 14382
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AudioComponentParam";

		// Token: 0x0400382F RID: 14383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003830 RID: 14384
		internal static int __PropertyOffset_ParamName;

		// Token: 0x04003831 RID: 14385
		internal static int __PropertyOffset_FloatParam;

		// Token: 0x04003832 RID: 14386
		internal static int __PropertyOffset_BoolParam;

		// Token: 0x04003833 RID: 14387
		internal static int __PropertyOffset_IntParam;

		// Token: 0x04003834 RID: 14388
		internal static int __PropertyOffset_SoundWaveParam;
	}
}
