using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F1 RID: 241
	[UnrealObjectPath("/Script/AIModule.AINoiseEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAINoiseEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012DE RID: 4830 RVA: 0x0001BF56 File Offset: 0x0001A156
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAINoiseEvent._ScriptStructPtr != 0) ? FAINoiseEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AINoiseEvent", ref FAINoiseEvent._ScriptStructPtr);
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0001BF7A File Offset: 0x0001A17A
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0001BF8E File Offset: 0x0001A18E
		public unsafe FVector NoiseLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_NoiseLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_NoiseLocation) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0001BFA3 File Offset: 0x0001A1A3
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0001BFB3 File Offset: 0x0001A1B3
		public unsafe float Loudness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_Loudness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_Loudness) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0001BFC4 File Offset: 0x0001A1C4
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0001BFE5 File Offset: 0x0001A1E5
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x0001BFF9 File Offset: 0x0001A1F9
		[Nullable(2)]
		public unsafe AActor Instigator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAINoiseEvent.__PropertyOffset_Instigator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAINoiseEvent.__PropertyOffset_Instigator, value);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0001C00E File Offset: 0x0001A20E
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0001C022 File Offset: 0x0001A222
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAINoiseEvent.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0001C037 File Offset: 0x0001A237
		public FAINoiseEvent()
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0001C03F File Offset: 0x0001A23F
		[NullableContext(1)]
		public FAINoiseEvent(FVector NoiseLocation, float Loudness, float MaxRange, AActor Instigator, FName Tag)
		{
			this.NoiseLocation = NoiseLocation;
			this.Loudness = Loudness;
			this.MaxRange = MaxRange;
			this.Instigator = Instigator;
			this.Tag = Tag;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0001C06C File Offset: 0x0001A26C
		protected override IntPtr GetUStructPtr()
		{
			return FAINoiseEvent.StaticStruct();
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0001C078 File Offset: 0x0001A278
		[NullableContext(2)]
		public FAINoiseEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0001C082 File Offset: 0x0001A282
		public FAINoiseEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0001C08D File Offset: 0x0001A28D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAINoiseEvent(Pointer, false, true);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0001C097 File Offset: 0x0001A297
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAINoiseEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04000353 RID: 851
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AINoiseEvent";

		// Token: 0x04000354 RID: 852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000355 RID: 853
		internal static int __PropertyOffset_NoiseLocation;

		// Token: 0x04000356 RID: 854
		internal static int __PropertyOffset_Loudness;

		// Token: 0x04000357 RID: 855
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x04000358 RID: 856
		internal static int __PropertyOffset_Instigator;

		// Token: 0x04000359 RID: 857
		internal static int __PropertyOffset_Tag;
	}
}
