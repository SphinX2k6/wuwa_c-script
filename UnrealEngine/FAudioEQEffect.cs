using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200086B RID: 2155
	[UnrealObjectPath("/Script/Engine.AudioEQEffect")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAudioEQEffect : FAudioEffectParameters, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060074F1 RID: 29937 RVA: 0x000A7A6B File Offset: 0x000A5C6B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioEQEffect._ScriptStructPtr != 0) ? FAudioEQEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioEQEffect", ref FAudioEQEffect._ScriptStructPtr);
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x060074F2 RID: 29938 RVA: 0x000A7A8F File Offset: 0x000A5C8F
		// (set) Token: 0x060074F3 RID: 29939 RVA: 0x000A7A9F File Offset: 0x000A5C9F
		public unsafe float FrequencyCenter0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter0) = value;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x000A7AB0 File Offset: 0x000A5CB0
		// (set) Token: 0x060074F5 RID: 29941 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
		public unsafe float Gain0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain0) = value;
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x060074F6 RID: 29942 RVA: 0x000A7AD1 File Offset: 0x000A5CD1
		// (set) Token: 0x060074F7 RID: 29943 RVA: 0x000A7AE1 File Offset: 0x000A5CE1
		public unsafe float Bandwidth0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth0) = value;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x060074F8 RID: 29944 RVA: 0x000A7AF2 File Offset: 0x000A5CF2
		// (set) Token: 0x060074F9 RID: 29945 RVA: 0x000A7B02 File Offset: 0x000A5D02
		public unsafe float FrequencyCenter1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter1) = value;
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x060074FA RID: 29946 RVA: 0x000A7B13 File Offset: 0x000A5D13
		// (set) Token: 0x060074FB RID: 29947 RVA: 0x000A7B23 File Offset: 0x000A5D23
		public unsafe float Gain1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain1) = value;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x000A7B34 File Offset: 0x000A5D34
		// (set) Token: 0x060074FD RID: 29949 RVA: 0x000A7B44 File Offset: 0x000A5D44
		public unsafe float Bandwidth1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth1) = value;
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x060074FE RID: 29950 RVA: 0x000A7B55 File Offset: 0x000A5D55
		// (set) Token: 0x060074FF RID: 29951 RVA: 0x000A7B65 File Offset: 0x000A5D65
		public unsafe float FrequencyCenter2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter2) = value;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x000A7B76 File Offset: 0x000A5D76
		// (set) Token: 0x06007501 RID: 29953 RVA: 0x000A7B86 File Offset: 0x000A5D86
		public unsafe float Gain2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain2) = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06007502 RID: 29954 RVA: 0x000A7B97 File Offset: 0x000A5D97
		// (set) Token: 0x06007503 RID: 29955 RVA: 0x000A7BA7 File Offset: 0x000A5DA7
		public unsafe float Bandwidth2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth2) = value;
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06007504 RID: 29956 RVA: 0x000A7BB8 File Offset: 0x000A5DB8
		// (set) Token: 0x06007505 RID: 29957 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
		public unsafe float FrequencyCenter3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_FrequencyCenter3) = value;
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06007506 RID: 29958 RVA: 0x000A7BD9 File Offset: 0x000A5DD9
		// (set) Token: 0x06007507 RID: 29959 RVA: 0x000A7BE9 File Offset: 0x000A5DE9
		public unsafe float Gain3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Gain3) = value;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06007508 RID: 29960 RVA: 0x000A7BFA File Offset: 0x000A5DFA
		// (set) Token: 0x06007509 RID: 29961 RVA: 0x000A7C0A File Offset: 0x000A5E0A
		public unsafe float Bandwidth3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioEQEffect.__PropertyOffset_Bandwidth3) = value;
			}
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x000A7C1B File Offset: 0x000A5E1B
		public FAudioEQEffect()
		{
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x000A7C24 File Offset: 0x000A5E24
		public FAudioEQEffect(float FrequencyCenter0, float Gain0, float Bandwidth0, float FrequencyCenter1, float Gain1, float Bandwidth1, float FrequencyCenter2, float Gain2, float Bandwidth2, float FrequencyCenter3, float Gain3, float Bandwidth3)
		{
			this.FrequencyCenter0 = FrequencyCenter0;
			this.Gain0 = Gain0;
			this.Bandwidth0 = Bandwidth0;
			this.FrequencyCenter1 = FrequencyCenter1;
			this.Gain1 = Gain1;
			this.Bandwidth1 = Bandwidth1;
			this.FrequencyCenter2 = FrequencyCenter2;
			this.Gain2 = Gain2;
			this.Bandwidth2 = Bandwidth2;
			this.FrequencyCenter3 = FrequencyCenter3;
			this.Gain3 = Gain3;
			this.Bandwidth3 = Bandwidth3;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x000A7C94 File Offset: 0x000A5E94
		protected override IntPtr GetUStructPtr()
		{
			return FAudioEQEffect.StaticStruct();
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x000A7CA0 File Offset: 0x000A5EA0
		[NullableContext(2)]
		public FAudioEQEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x000A7CAA File Offset: 0x000A5EAA
		public FAudioEQEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x000A7CB5 File Offset: 0x000A5EB5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioEQEffect(Pointer, false, true);
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x000A7CBF File Offset: 0x000A5EBF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioEQEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04003837 RID: 14391
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AudioEQEffect";

		// Token: 0x04003838 RID: 14392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003839 RID: 14393
		internal static int __PropertyOffset_FrequencyCenter0;

		// Token: 0x0400383A RID: 14394
		internal static int __PropertyOffset_Gain0;

		// Token: 0x0400383B RID: 14395
		internal static int __PropertyOffset_Bandwidth0;

		// Token: 0x0400383C RID: 14396
		internal static int __PropertyOffset_FrequencyCenter1;

		// Token: 0x0400383D RID: 14397
		internal static int __PropertyOffset_Gain1;

		// Token: 0x0400383E RID: 14398
		internal static int __PropertyOffset_Bandwidth1;

		// Token: 0x0400383F RID: 14399
		internal static int __PropertyOffset_FrequencyCenter2;

		// Token: 0x04003840 RID: 14400
		internal static int __PropertyOffset_Gain2;

		// Token: 0x04003841 RID: 14401
		internal static int __PropertyOffset_Bandwidth2;

		// Token: 0x04003842 RID: 14402
		internal static int __PropertyOffset_FrequencyCenter3;

		// Token: 0x04003843 RID: 14403
		internal static int __PropertyOffset_Gain3;

		// Token: 0x04003844 RID: 14404
		internal static int __PropertyOffset_Bandwidth3;
	}
}
