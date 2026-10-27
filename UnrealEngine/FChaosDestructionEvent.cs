using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200043D RID: 1085
	[UnrealObjectPath("/Script/ChaosNiagara.ChaosDestructionEvent")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FChaosDestructionEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003AA9 RID: 15017 RVA: 0x00058A69 File Offset: 0x00056C69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosDestructionEvent._ScriptStructPtr != 0) ? FChaosDestructionEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosNiagara.ChaosDestructionEvent", ref FChaosDestructionEvent._ScriptStructPtr);
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x00058A8D File Offset: 0x00056C8D
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x00058AA1 File Offset: 0x00056CA1
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00058AB6 File Offset: 0x00056CB6
		// (set) Token: 0x06003AAD RID: 15021 RVA: 0x00058ACA File Offset: 0x00056CCA
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x00058ADF File Offset: 0x00056CDF
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x00058AF3 File Offset: 0x00056CF3
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x00058B08 File Offset: 0x00056D08
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x00058B1C File Offset: 0x00056D1C
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x00058B31 File Offset: 0x00056D31
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x00058B41 File Offset: 0x00056D41
		public unsafe float ExtentMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ExtentMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ExtentMin) = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x00058B52 File Offset: 0x00056D52
		// (set) Token: 0x06003AB5 RID: 15029 RVA: 0x00058B62 File Offset: 0x00056D62
		public unsafe float ExtentMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ExtentMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ExtentMax) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x00058B73 File Offset: 0x00056D73
		// (set) Token: 0x06003AB7 RID: 15031 RVA: 0x00058B83 File Offset: 0x00056D83
		public unsafe int ParticleID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ParticleID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_ParticleID) = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00058B94 File Offset: 0x00056D94
		// (set) Token: 0x06003AB9 RID: 15033 RVA: 0x00058BA4 File Offset: 0x00056DA4
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00058BB5 File Offset: 0x00056DB5
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x00058BC5 File Offset: 0x00056DC5
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDestructionEvent.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00058BD6 File Offset: 0x00056DD6
		public FChaosDestructionEvent()
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00058BE0 File Offset: 0x00056DE0
		public FChaosDestructionEvent(FVector Position, FVector Normal, FVector Velocity, FVector AngularVelocity, float ExtentMin, float ExtentMax, int ParticleID, float Time, int Type)
		{
			this.Position = Position;
			this.Normal = Normal;
			this.Velocity = Velocity;
			this.AngularVelocity = AngularVelocity;
			this.ExtentMin = ExtentMin;
			this.ExtentMax = ExtentMax;
			this.ParticleID = ParticleID;
			this.Time = Time;
			this.Type = Type;
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00058C38 File Offset: 0x00056E38
		protected override IntPtr GetUStructPtr()
		{
			return FChaosDestructionEvent.StaticStruct();
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00058C44 File Offset: 0x00056E44
		[NullableContext(2)]
		public FChaosDestructionEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00058C4E File Offset: 0x00056E4E
		public FChaosDestructionEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00058C59 File Offset: 0x00056E59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosDestructionEvent(Pointer, false, true);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00058C63 File Offset: 0x00056E63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosDestructionEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04001AC7 RID: 6855
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosNiagara.ChaosDestructionEvent";

		// Token: 0x04001AC8 RID: 6856
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001AC9 RID: 6857
		internal static int __PropertyOffset_Position;

		// Token: 0x04001ACA RID: 6858
		internal static int __PropertyOffset_Normal;

		// Token: 0x04001ACB RID: 6859
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001ACC RID: 6860
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04001ACD RID: 6861
		internal static int __PropertyOffset_ExtentMin;

		// Token: 0x04001ACE RID: 6862
		internal static int __PropertyOffset_ExtentMax;

		// Token: 0x04001ACF RID: 6863
		internal static int __PropertyOffset_ParticleID;

		// Token: 0x04001AD0 RID: 6864
		internal static int __PropertyOffset_Time;

		// Token: 0x04001AD1 RID: 6865
		internal static int __PropertyOffset_Type;
	}
}
