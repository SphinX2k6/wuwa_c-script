using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002485 RID: 9349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavCollision")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UNavCollision : UNavCollisionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F73 RID: 143219 RVA: 0x0033B23A File Offset: 0x0033943A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavCollision._ClassPtr;
		}

		// Token: 0x06022F74 RID: 143220 RVA: 0x0033B248 File Offset: 0x00339448
		public UNavCollision() : this(BuiltinUtils.AllocNativeUObject(UNavCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F75 RID: 143221 RVA: 0x0033B270 File Offset: 0x00339470
		public UNavCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700864E RID: 34382
		// (get) Token: 0x06022F76 RID: 143222 RVA: 0x0033B2A4 File Offset: 0x003394A4
		// (set) Token: 0x06022F77 RID: 143223 RVA: 0x0033B2DD File Offset: 0x003394DD
		public TArray<FNavCollisionCylinder> CylinderCollision
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavCollisionCylinder> result;
				if ((result = this._CylinderCollision) == null)
				{
					result = (this._CylinderCollision = new TArray<FNavCollisionCylinder>(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_CylinderCollision, this));
				}
				return result;
			}
			set
			{
				this.CylinderCollision.CopyAssign(value);
			}
		}

		// Token: 0x1700864F RID: 34383
		// (get) Token: 0x06022F78 RID: 143224 RVA: 0x0033B2EC File Offset: 0x003394EC
		// (set) Token: 0x06022F79 RID: 143225 RVA: 0x0033B325 File Offset: 0x00339525
		public TArray<FNavCollisionBox> BoxCollision
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavCollisionBox> result;
				if ((result = this._BoxCollision) == null)
				{
					result = (this._BoxCollision = new TArray<FNavCollisionBox>(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_BoxCollision, this));
				}
				return result;
			}
			set
			{
				this.BoxCollision.CopyAssign(value);
			}
		}

		// Token: 0x17008650 RID: 34384
		// (get) Token: 0x06022F7A RID: 143226 RVA: 0x0033B333 File Offset: 0x00339533
		// (set) Token: 0x06022F7B RID: 143227 RVA: 0x0033B347 File Offset: 0x00339547
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x17008651 RID: 34385
		// (get) Token: 0x06022F7C RID: 143228 RVA: 0x0033B35C File Offset: 0x0033955C
		// (set) Token: 0x06022F7D RID: 143229 RVA: 0x0033B375 File Offset: 0x00339575
		public unsafe bool bGatherConvexGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bGatherConvexGeometry) & UNavCollision.__PropertyMask_bGatherConvexGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bGatherConvexGeometry) = ((*(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bGatherConvexGeometry) & ~UNavCollision.__PropertyMask_bGatherConvexGeometry) | (value ? UNavCollision.__PropertyMask_bGatherConvexGeometry : 0));
			}
		}

		// Token: 0x17008652 RID: 34386
		// (get) Token: 0x06022F7E RID: 143230 RVA: 0x0033B3A5 File Offset: 0x003395A5
		// (set) Token: 0x06022F7F RID: 143231 RVA: 0x0033B3BE File Offset: 0x003395BE
		public unsafe bool bCreateOnClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bCreateOnClient) & UNavCollision.__PropertyMask_bCreateOnClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bCreateOnClient) = ((*(base.NativePtr + (IntPtr)UNavCollision.__PropertyOffset_bCreateOnClient) & ~UNavCollision.__PropertyMask_bCreateOnClient) | (value ? UNavCollision.__PropertyMask_bCreateOnClient : 0));
			}
		}

		// Token: 0x06022F80 RID: 143232 RVA: 0x0033B3EE File Offset: 0x003395EE
		static UNavCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavCollision");
		}

		// Token: 0x06022F81 RID: 143233 RVA: 0x0033B3FC File Offset: 0x003395FC
		protected UNavCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012ABF RID: 76479
		public new const string __ObjectPath = "/Script/NavigationSystem.NavCollision";

		// Token: 0x04012AC0 RID: 76480
		private static IntPtr _ClassPtr;

		// Token: 0x04012AC1 RID: 76481
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AC2 RID: 76482
		internal static int __PropertyOffset_CylinderCollision;

		// Token: 0x04012AC3 RID: 76483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavCollisionCylinder> _CylinderCollision;

		// Token: 0x04012AC4 RID: 76484
		internal static int __PropertyOffset_BoxCollision;

		// Token: 0x04012AC5 RID: 76485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavCollisionBox> _BoxCollision;

		// Token: 0x04012AC6 RID: 76486
		internal static int __PropertyOffset_AreaClass;

		// Token: 0x04012AC7 RID: 76487
		internal static int __PropertyOffset_bGatherConvexGeometry;

		// Token: 0x04012AC8 RID: 76488
		internal static byte __PropertyMask_bGatherConvexGeometry;

		// Token: 0x04012AC9 RID: 76489
		internal static int __PropertyOffset_bCreateOnClient;

		// Token: 0x04012ACA RID: 76490
		internal static byte __PropertyMask_bCreateOnClient;
	}
}
