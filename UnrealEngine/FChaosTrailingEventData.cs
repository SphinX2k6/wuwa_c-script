using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001420 RID: 5152
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FChaosTrailingEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012CF1 RID: 77041 RVA: 0x001BAB19 File Offset: 0x001B8D19
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosTrailingEventData._ScriptStructPtr != 0) ? FChaosTrailingEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosTrailingEventData", ref FChaosTrailingEventData._ScriptStructPtr);
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06012CF2 RID: 77042 RVA: 0x001BAB3D File Offset: 0x001B8D3D
		// (set) Token: 0x06012CF3 RID: 77043 RVA: 0x001BAB51 File Offset: 0x001B8D51
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06012CF4 RID: 77044 RVA: 0x001BAB66 File Offset: 0x001B8D66
		// (set) Token: 0x06012CF5 RID: 77045 RVA: 0x001BAB7A File Offset: 0x001B8D7A
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06012CF6 RID: 77046 RVA: 0x001BAB8F File Offset: 0x001B8D8F
		// (set) Token: 0x06012CF7 RID: 77047 RVA: 0x001BABA3 File Offset: 0x001B8DA3
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06012CF8 RID: 77048 RVA: 0x001BABB8 File Offset: 0x001B8DB8
		// (set) Token: 0x06012CF9 RID: 77049 RVA: 0x001BABC8 File Offset: 0x001B8DC8
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06012CFA RID: 77050 RVA: 0x001BABD9 File Offset: 0x001B8DD9
		// (set) Token: 0x06012CFB RID: 77051 RVA: 0x001BABE9 File Offset: 0x001B8DE9
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventData.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x06012CFC RID: 77052 RVA: 0x001BABFA File Offset: 0x001B8DFA
		public FChaosTrailingEventData()
		{
		}

		// Token: 0x06012CFD RID: 77053 RVA: 0x001BAC02 File Offset: 0x001B8E02
		public FChaosTrailingEventData(FVector Location, FVector Velocity, FVector AngularVelocity, float Mass, int ParticleIndex)
		{
			this.Location = Location;
			this.Velocity = Velocity;
			this.AngularVelocity = AngularVelocity;
			this.Mass = Mass;
			this.ParticleIndex = ParticleIndex;
		}

		// Token: 0x06012CFE RID: 77054 RVA: 0x001BAC2F File Offset: 0x001B8E2F
		protected override IntPtr GetUStructPtr()
		{
			return FChaosTrailingEventData.StaticStruct();
		}

		// Token: 0x06012CFF RID: 77055 RVA: 0x001BAC3B File Offset: 0x001B8E3B
		[NullableContext(2)]
		public FChaosTrailingEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012D00 RID: 77056 RVA: 0x001BAC45 File Offset: 0x001B8E45
		public FChaosTrailingEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012D01 RID: 77057 RVA: 0x001BAC50 File Offset: 0x001B8E50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosTrailingEventData(Pointer, false, true);
		}

		// Token: 0x06012D02 RID: 77058 RVA: 0x001BAC5A File Offset: 0x001B8E5A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosTrailingEventData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A0BC RID: 41148
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosTrailingEventData";

		// Token: 0x0400A0BD RID: 41149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A0BE RID: 41150
		internal static int __PropertyOffset_Location;

		// Token: 0x0400A0BF RID: 41151
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400A0C0 RID: 41152
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x0400A0C1 RID: 41153
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400A0C2 RID: 41154
		internal static int __PropertyOffset_ParticleIndex;
	}
}
