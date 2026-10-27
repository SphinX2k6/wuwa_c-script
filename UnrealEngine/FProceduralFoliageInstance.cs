using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D6 RID: 4822
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageInstance")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FProceduralFoliageInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011AF8 RID: 72440 RVA: 0x0019F802 File Offset: 0x0019DA02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProceduralFoliageInstance._ScriptStructPtr != 0) ? FProceduralFoliageInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Foliage.ProceduralFoliageInstance", ref FProceduralFoliageInstance._ScriptStructPtr);
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x06011AF9 RID: 72441 RVA: 0x0019F826 File Offset: 0x0019DA26
		// (set) Token: 0x06011AFA RID: 72442 RVA: 0x0019F83A File Offset: 0x0019DA3A
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x06011AFB RID: 72443 RVA: 0x0019F84F File Offset: 0x0019DA4F
		// (set) Token: 0x06011AFC RID: 72444 RVA: 0x0019F863 File Offset: 0x0019DA63
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x06011AFD RID: 72445 RVA: 0x0019F878 File Offset: 0x0019DA78
		// (set) Token: 0x06011AFE RID: 72446 RVA: 0x0019F888 File Offset: 0x0019DA88
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Age);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Age) = value;
			}
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x06011AFF RID: 72447 RVA: 0x0019F899 File Offset: 0x0019DA99
		// (set) Token: 0x06011B00 RID: 72448 RVA: 0x0019F8AD File Offset: 0x0019DAAD
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x06011B01 RID: 72449 RVA: 0x0019F8C2 File Offset: 0x0019DAC2
		// (set) Token: 0x06011B02 RID: 72450 RVA: 0x0019F8D2 File Offset: 0x0019DAD2
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProceduralFoliageInstance.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x06011B03 RID: 72451 RVA: 0x0019F8E3 File Offset: 0x0019DAE3
		// (set) Token: 0x06011B04 RID: 72452 RVA: 0x0019F8F7 File Offset: 0x0019DAF7
		[Nullable(2)]
		public unsafe UFoliageType Type
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType>(base.NativePtr / (IntPtr)sizeof(void*) + FProceduralFoliageInstance.__PropertyOffset_Type);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FProceduralFoliageInstance.__PropertyOffset_Type, value);
			}
		}

		// Token: 0x06011B05 RID: 72453 RVA: 0x0019F90C File Offset: 0x0019DB0C
		public FProceduralFoliageInstance()
		{
		}

		// Token: 0x06011B06 RID: 72454 RVA: 0x0019F914 File Offset: 0x0019DB14
		[NullableContext(1)]
		public FProceduralFoliageInstance(FQuat Rotation, FVector Location, float Age, FVector Normal, float Scale, UFoliageType Type)
		{
			this.Rotation = Rotation;
			this.Location = Location;
			this.Age = Age;
			this.Normal = Normal;
			this.Scale = Scale;
			this.Type = Type;
		}

		// Token: 0x06011B07 RID: 72455 RVA: 0x0019F949 File Offset: 0x0019DB49
		protected override IntPtr GetUStructPtr()
		{
			return FProceduralFoliageInstance.StaticStruct();
		}

		// Token: 0x06011B08 RID: 72456 RVA: 0x0019F955 File Offset: 0x0019DB55
		[NullableContext(2)]
		public FProceduralFoliageInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011B09 RID: 72457 RVA: 0x0019F95F File Offset: 0x0019DB5F
		public FProceduralFoliageInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011B0A RID: 72458 RVA: 0x0019F96A File Offset: 0x0019DB6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProceduralFoliageInstance(Pointer, false, true);
		}

		// Token: 0x06011B0B RID: 72459 RVA: 0x0019F974 File Offset: 0x0019DB74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProceduralFoliageInstance(Pointer, MemoryOwner);
		}

		// Token: 0x040097CB RID: 38859
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Foliage.ProceduralFoliageInstance";

		// Token: 0x040097CC RID: 38860
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040097CD RID: 38861
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040097CE RID: 38862
		internal static int __PropertyOffset_Location;

		// Token: 0x040097CF RID: 38863
		internal static int __PropertyOffset_Age;

		// Token: 0x040097D0 RID: 38864
		internal static int __PropertyOffset_Normal;

		// Token: 0x040097D1 RID: 38865
		internal static int __PropertyOffset_Scale;

		// Token: 0x040097D2 RID: 38866
		internal static int __PropertyOffset_Type;
	}
}
