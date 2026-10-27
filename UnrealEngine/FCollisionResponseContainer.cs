using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000947 RID: 2375
	[UnrealObjectPath("/Script/Engine.CollisionResponseContainer")]
	[UnrealStructLayout(32, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCollisionResponseContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600863A RID: 34362 RVA: 0x000BF4D7 File Offset: 0x000BD6D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionResponseContainer._ScriptStructPtr != 0) ? FCollisionResponseContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionResponseContainer", ref FCollisionResponseContainer._ScriptStructPtr);
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x000BF4FB File Offset: 0x000BD6FB
		// (set) Token: 0x0600863C RID: 34364 RVA: 0x000BF50F File Offset: 0x000BD70F
		public unsafe TEnumAsByte<ECollisionResponse> WorldStatic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldStatic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldStatic) = value;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x000BF524 File Offset: 0x000BD724
		// (set) Token: 0x0600863E RID: 34366 RVA: 0x000BF538 File Offset: 0x000BD738
		public unsafe TEnumAsByte<ECollisionResponse> WorldDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldDynamic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_WorldDynamic) = value;
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x000BF54D File Offset: 0x000BD74D
		// (set) Token: 0x06008640 RID: 34368 RVA: 0x000BF561 File Offset: 0x000BD761
		public unsafe TEnumAsByte<ECollisionResponse> Pawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Pawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Pawn) = value;
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06008641 RID: 34369 RVA: 0x000BF576 File Offset: 0x000BD776
		// (set) Token: 0x06008642 RID: 34370 RVA: 0x000BF58A File Offset: 0x000BD78A
		public unsafe TEnumAsByte<ECollisionResponse> Visibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Visibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Visibility) = value;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06008643 RID: 34371 RVA: 0x000BF59F File Offset: 0x000BD79F
		// (set) Token: 0x06008644 RID: 34372 RVA: 0x000BF5B3 File Offset: 0x000BD7B3
		public unsafe TEnumAsByte<ECollisionResponse> Camera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Camera);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Camera) = value;
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06008645 RID: 34373 RVA: 0x000BF5C8 File Offset: 0x000BD7C8
		// (set) Token: 0x06008646 RID: 34374 RVA: 0x000BF5DC File Offset: 0x000BD7DC
		public unsafe TEnumAsByte<ECollisionResponse> PhysicsBody
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_PhysicsBody);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_PhysicsBody) = value;
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06008647 RID: 34375 RVA: 0x000BF5F1 File Offset: 0x000BD7F1
		// (set) Token: 0x06008648 RID: 34376 RVA: 0x000BF605 File Offset: 0x000BD805
		public unsafe TEnumAsByte<ECollisionResponse> Vehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Vehicle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Vehicle) = value;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06008649 RID: 34377 RVA: 0x000BF61A File Offset: 0x000BD81A
		// (set) Token: 0x0600864A RID: 34378 RVA: 0x000BF62E File Offset: 0x000BD82E
		public unsafe TEnumAsByte<ECollisionResponse> Destructible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Destructible);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_Destructible) = value;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600864B RID: 34379 RVA: 0x000BF643 File Offset: 0x000BD843
		// (set) Token: 0x0600864C RID: 34380 RVA: 0x000BF657 File Offset: 0x000BD857
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel1) = value;
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600864D RID: 34381 RVA: 0x000BF66C File Offset: 0x000BD86C
		// (set) Token: 0x0600864E RID: 34382 RVA: 0x000BF680 File Offset: 0x000BD880
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel2) = value;
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600864F RID: 34383 RVA: 0x000BF695 File Offset: 0x000BD895
		// (set) Token: 0x06008650 RID: 34384 RVA: 0x000BF6A9 File Offset: 0x000BD8A9
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel3) = value;
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x000BF6BE File Offset: 0x000BD8BE
		// (set) Token: 0x06008652 RID: 34386 RVA: 0x000BF6D2 File Offset: 0x000BD8D2
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel4) = value;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x000BF6E7 File Offset: 0x000BD8E7
		// (set) Token: 0x06008654 RID: 34388 RVA: 0x000BF6FB File Offset: 0x000BD8FB
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel5) = value;
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06008655 RID: 34389 RVA: 0x000BF710 File Offset: 0x000BD910
		// (set) Token: 0x06008656 RID: 34390 RVA: 0x000BF724 File Offset: 0x000BD924
		public unsafe TEnumAsByte<ECollisionResponse> EngineTraceChannel6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_EngineTraceChannel6) = value;
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06008657 RID: 34391 RVA: 0x000BF739 File Offset: 0x000BD939
		// (set) Token: 0x06008658 RID: 34392 RVA: 0x000BF74D File Offset: 0x000BD94D
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel1) = value;
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06008659 RID: 34393 RVA: 0x000BF762 File Offset: 0x000BD962
		// (set) Token: 0x0600865A RID: 34394 RVA: 0x000BF776 File Offset: 0x000BD976
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel2) = value;
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x000BF78B File Offset: 0x000BD98B
		// (set) Token: 0x0600865C RID: 34396 RVA: 0x000BF79F File Offset: 0x000BD99F
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel3) = value;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x000BF7B4 File Offset: 0x000BD9B4
		// (set) Token: 0x0600865E RID: 34398 RVA: 0x000BF7C8 File Offset: 0x000BD9C8
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel4) = value;
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600865F RID: 34399 RVA: 0x000BF7DD File Offset: 0x000BD9DD
		// (set) Token: 0x06008660 RID: 34400 RVA: 0x000BF7F1 File Offset: 0x000BD9F1
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel5) = value;
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06008661 RID: 34401 RVA: 0x000BF806 File Offset: 0x000BDA06
		// (set) Token: 0x06008662 RID: 34402 RVA: 0x000BF81A File Offset: 0x000BDA1A
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel6) = value;
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06008663 RID: 34403 RVA: 0x000BF82F File Offset: 0x000BDA2F
		// (set) Token: 0x06008664 RID: 34404 RVA: 0x000BF843 File Offset: 0x000BDA43
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel7) = value;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06008665 RID: 34405 RVA: 0x000BF858 File Offset: 0x000BDA58
		// (set) Token: 0x06008666 RID: 34406 RVA: 0x000BF86C File Offset: 0x000BDA6C
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel8) = value;
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x000BF881 File Offset: 0x000BDA81
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x000BF895 File Offset: 0x000BDA95
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel9
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel9) = value;
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x000BF8AA File Offset: 0x000BDAAA
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x000BF8BE File Offset: 0x000BDABE
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel10
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel10) = value;
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x000BF8D3 File Offset: 0x000BDAD3
		// (set) Token: 0x0600866C RID: 34412 RVA: 0x000BF8E7 File Offset: 0x000BDAE7
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel11) = value;
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x000BF910 File Offset: 0x000BDB10
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel12) = value;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600866F RID: 34415 RVA: 0x000BF925 File Offset: 0x000BDB25
		// (set) Token: 0x06008670 RID: 34416 RVA: 0x000BF939 File Offset: 0x000BDB39
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel13
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel13) = value;
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06008671 RID: 34417 RVA: 0x000BF94E File Offset: 0x000BDB4E
		// (set) Token: 0x06008672 RID: 34418 RVA: 0x000BF962 File Offset: 0x000BDB62
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel14
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel14) = value;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06008673 RID: 34419 RVA: 0x000BF977 File Offset: 0x000BDB77
		// (set) Token: 0x06008674 RID: 34420 RVA: 0x000BF98B File Offset: 0x000BDB8B
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel15
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel15) = value;
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06008675 RID: 34421 RVA: 0x000BF9A0 File Offset: 0x000BDBA0
		// (set) Token: 0x06008676 RID: 34422 RVA: 0x000BF9B4 File Offset: 0x000BDBB4
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel16) = value;
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06008677 RID: 34423 RVA: 0x000BF9C9 File Offset: 0x000BDBC9
		// (set) Token: 0x06008678 RID: 34424 RVA: 0x000BF9DD File Offset: 0x000BDBDD
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel17
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel17) = value;
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06008679 RID: 34425 RVA: 0x000BF9F2 File Offset: 0x000BDBF2
		// (set) Token: 0x0600867A RID: 34426 RVA: 0x000BFA06 File Offset: 0x000BDC06
		public unsafe TEnumAsByte<ECollisionResponse> GameTraceChannel18
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionResponseContainer.__PropertyOffset_GameTraceChannel18) = value;
			}
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x000BFA1B File Offset: 0x000BDC1B
		public FCollisionResponseContainer()
		{
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x000BFA24 File Offset: 0x000BDC24
		public FCollisionResponseContainer(TEnumAsByte<ECollisionResponse> WorldStatic, TEnumAsByte<ECollisionResponse> WorldDynamic, TEnumAsByte<ECollisionResponse> Pawn, TEnumAsByte<ECollisionResponse> Visibility, TEnumAsByte<ECollisionResponse> Camera, TEnumAsByte<ECollisionResponse> PhysicsBody, TEnumAsByte<ECollisionResponse> Vehicle, TEnumAsByte<ECollisionResponse> Destructible, TEnumAsByte<ECollisionResponse> EngineTraceChannel1, TEnumAsByte<ECollisionResponse> EngineTraceChannel2, TEnumAsByte<ECollisionResponse> EngineTraceChannel3, TEnumAsByte<ECollisionResponse> EngineTraceChannel4, TEnumAsByte<ECollisionResponse> EngineTraceChannel5, TEnumAsByte<ECollisionResponse> EngineTraceChannel6, TEnumAsByte<ECollisionResponse> GameTraceChannel1, TEnumAsByte<ECollisionResponse> GameTraceChannel2, TEnumAsByte<ECollisionResponse> GameTraceChannel3, TEnumAsByte<ECollisionResponse> GameTraceChannel4, TEnumAsByte<ECollisionResponse> GameTraceChannel5, TEnumAsByte<ECollisionResponse> GameTraceChannel6, TEnumAsByte<ECollisionResponse> GameTraceChannel7, TEnumAsByte<ECollisionResponse> GameTraceChannel8, TEnumAsByte<ECollisionResponse> GameTraceChannel9, TEnumAsByte<ECollisionResponse> GameTraceChannel10, TEnumAsByte<ECollisionResponse> GameTraceChannel11, TEnumAsByte<ECollisionResponse> GameTraceChannel12, TEnumAsByte<ECollisionResponse> GameTraceChannel13, TEnumAsByte<ECollisionResponse> GameTraceChannel14, TEnumAsByte<ECollisionResponse> GameTraceChannel15, TEnumAsByte<ECollisionResponse> GameTraceChannel16, TEnumAsByte<ECollisionResponse> GameTraceChannel17, TEnumAsByte<ECollisionResponse> GameTraceChannel18)
		{
			this.WorldStatic = WorldStatic;
			this.WorldDynamic = WorldDynamic;
			this.Pawn = Pawn;
			this.Visibility = Visibility;
			this.Camera = Camera;
			this.PhysicsBody = PhysicsBody;
			this.Vehicle = Vehicle;
			this.Destructible = Destructible;
			this.EngineTraceChannel1 = EngineTraceChannel1;
			this.EngineTraceChannel2 = EngineTraceChannel2;
			this.EngineTraceChannel3 = EngineTraceChannel3;
			this.EngineTraceChannel4 = EngineTraceChannel4;
			this.EngineTraceChannel5 = EngineTraceChannel5;
			this.EngineTraceChannel6 = EngineTraceChannel6;
			this.GameTraceChannel1 = GameTraceChannel1;
			this.GameTraceChannel2 = GameTraceChannel2;
			this.GameTraceChannel3 = GameTraceChannel3;
			this.GameTraceChannel4 = GameTraceChannel4;
			this.GameTraceChannel5 = GameTraceChannel5;
			this.GameTraceChannel6 = GameTraceChannel6;
			this.GameTraceChannel7 = GameTraceChannel7;
			this.GameTraceChannel8 = GameTraceChannel8;
			this.GameTraceChannel9 = GameTraceChannel9;
			this.GameTraceChannel10 = GameTraceChannel10;
			this.GameTraceChannel11 = GameTraceChannel11;
			this.GameTraceChannel12 = GameTraceChannel12;
			this.GameTraceChannel13 = GameTraceChannel13;
			this.GameTraceChannel14 = GameTraceChannel14;
			this.GameTraceChannel15 = GameTraceChannel15;
			this.GameTraceChannel16 = GameTraceChannel16;
			this.GameTraceChannel17 = GameTraceChannel17;
			this.GameTraceChannel18 = GameTraceChannel18;
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x000BFB34 File Offset: 0x000BDD34
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionResponseContainer.StaticStruct();
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x000BFB40 File Offset: 0x000BDD40
		[NullableContext(2)]
		public FCollisionResponseContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x000BFB4A File Offset: 0x000BDD4A
		public FCollisionResponseContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x000BFB55 File Offset: 0x000BDD55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionResponseContainer(Pointer, false, true);
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x000BFB5F File Offset: 0x000BDD5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionResponseContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04003FDC RID: 16348
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollisionResponseContainer";

		// Token: 0x04003FDD RID: 16349
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FDE RID: 16350
		internal static int __PropertyOffset_WorldStatic;

		// Token: 0x04003FDF RID: 16351
		internal static int __PropertyOffset_WorldDynamic;

		// Token: 0x04003FE0 RID: 16352
		internal static int __PropertyOffset_Pawn;

		// Token: 0x04003FE1 RID: 16353
		internal static int __PropertyOffset_Visibility;

		// Token: 0x04003FE2 RID: 16354
		internal static int __PropertyOffset_Camera;

		// Token: 0x04003FE3 RID: 16355
		internal static int __PropertyOffset_PhysicsBody;

		// Token: 0x04003FE4 RID: 16356
		internal static int __PropertyOffset_Vehicle;

		// Token: 0x04003FE5 RID: 16357
		internal static int __PropertyOffset_Destructible;

		// Token: 0x04003FE6 RID: 16358
		internal static int __PropertyOffset_EngineTraceChannel1;

		// Token: 0x04003FE7 RID: 16359
		internal static int __PropertyOffset_EngineTraceChannel2;

		// Token: 0x04003FE8 RID: 16360
		internal static int __PropertyOffset_EngineTraceChannel3;

		// Token: 0x04003FE9 RID: 16361
		internal static int __PropertyOffset_EngineTraceChannel4;

		// Token: 0x04003FEA RID: 16362
		internal static int __PropertyOffset_EngineTraceChannel5;

		// Token: 0x04003FEB RID: 16363
		internal static int __PropertyOffset_EngineTraceChannel6;

		// Token: 0x04003FEC RID: 16364
		internal static int __PropertyOffset_GameTraceChannel1;

		// Token: 0x04003FED RID: 16365
		internal static int __PropertyOffset_GameTraceChannel2;

		// Token: 0x04003FEE RID: 16366
		internal static int __PropertyOffset_GameTraceChannel3;

		// Token: 0x04003FEF RID: 16367
		internal static int __PropertyOffset_GameTraceChannel4;

		// Token: 0x04003FF0 RID: 16368
		internal static int __PropertyOffset_GameTraceChannel5;

		// Token: 0x04003FF1 RID: 16369
		internal static int __PropertyOffset_GameTraceChannel6;

		// Token: 0x04003FF2 RID: 16370
		internal static int __PropertyOffset_GameTraceChannel7;

		// Token: 0x04003FF3 RID: 16371
		internal static int __PropertyOffset_GameTraceChannel8;

		// Token: 0x04003FF4 RID: 16372
		internal static int __PropertyOffset_GameTraceChannel9;

		// Token: 0x04003FF5 RID: 16373
		internal static int __PropertyOffset_GameTraceChannel10;

		// Token: 0x04003FF6 RID: 16374
		internal static int __PropertyOffset_GameTraceChannel11;

		// Token: 0x04003FF7 RID: 16375
		internal static int __PropertyOffset_GameTraceChannel12;

		// Token: 0x04003FF8 RID: 16376
		internal static int __PropertyOffset_GameTraceChannel13;

		// Token: 0x04003FF9 RID: 16377
		internal static int __PropertyOffset_GameTraceChannel14;

		// Token: 0x04003FFA RID: 16378
		internal static int __PropertyOffset_GameTraceChannel15;

		// Token: 0x04003FFB RID: 16379
		internal static int __PropertyOffset_GameTraceChannel16;

		// Token: 0x04003FFC RID: 16380
		internal static int __PropertyOffset_GameTraceChannel17;

		// Token: 0x04003FFD RID: 16381
		internal static int __PropertyOffset_GameTraceChannel18;
	}
}
