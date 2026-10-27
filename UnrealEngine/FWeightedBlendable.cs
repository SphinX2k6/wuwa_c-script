using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001245 RID: 4677
	[UnrealObjectPath("/Script/Engine.WeightedBlendable")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWeightedBlendable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011304 RID: 70404 RVA: 0x00193875 File Offset: 0x00191A75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWeightedBlendable._ScriptStructPtr != 0) ? FWeightedBlendable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WeightedBlendable", ref FWeightedBlendable._ScriptStructPtr);
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x06011305 RID: 70405 RVA: 0x00193899 File Offset: 0x00191A99
		// (set) Token: 0x06011306 RID: 70406 RVA: 0x001938A9 File Offset: 0x00191AA9
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWeightedBlendable.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWeightedBlendable.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x06011307 RID: 70407 RVA: 0x001938BA File Offset: 0x00191ABA
		// (set) Token: 0x06011308 RID: 70408 RVA: 0x001938CE File Offset: 0x00191ACE
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FWeightedBlendable.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FWeightedBlendable.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x06011309 RID: 70409 RVA: 0x001938E3 File Offset: 0x00191AE3
		public FWeightedBlendable()
		{
		}

		// Token: 0x0601130A RID: 70410 RVA: 0x001938EB File Offset: 0x00191AEB
		[NullableContext(1)]
		public FWeightedBlendable(float Weight, UObject Object)
		{
			this.Weight = Weight;
			this.Object = Object;
		}

		// Token: 0x0601130B RID: 70411 RVA: 0x00193901 File Offset: 0x00191B01
		protected override IntPtr GetUStructPtr()
		{
			return FWeightedBlendable.StaticStruct();
		}

		// Token: 0x0601130C RID: 70412 RVA: 0x0019390D File Offset: 0x00191B0D
		[NullableContext(2)]
		public FWeightedBlendable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601130D RID: 70413 RVA: 0x00193917 File Offset: 0x00191B17
		public FWeightedBlendable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601130E RID: 70414 RVA: 0x00193922 File Offset: 0x00191B22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWeightedBlendable(Pointer, false, true);
		}

		// Token: 0x0601130F RID: 70415 RVA: 0x0019392C File Offset: 0x00191B2C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWeightedBlendable(Pointer, MemoryOwner);
		}

		// Token: 0x04009314 RID: 37652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WeightedBlendable";

		// Token: 0x04009315 RID: 37653
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009316 RID: 37654
		internal static int __PropertyOffset_Weight;

		// Token: 0x04009317 RID: 37655
		internal static int __PropertyOffset_Object;
	}
}
